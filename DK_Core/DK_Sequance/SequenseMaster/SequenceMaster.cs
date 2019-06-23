using System.Collections.Generic;

using UnityEngine;

using DG.Tweening;
using DG.Tweening.Core;

namespace DK.Tweening
{
    public partial class SequenceMaster
    {
        public static readonly DKSequence instance;

        public static GameObject target => branchStack.Peek().target;
        public static Sequence sequence => branchStack.Peek().sequence;

        private static Stack<(GameObject target, Sequence sequence, BranchType type)> branchStack =
                   new Stack<(GameObject target, Sequence sequence, BranchType type)>(5);
        
        public static Tween tween { get; private set; }

        public enum BranchType {None, Main, Sync, Async}

        static SequenceMaster()
        {
            instance = new DKSequence();
        }

        public static DKSequence CreateSequence(GameObject node, string name = "")
        {
            if (branchStack.Count > 1)
                throw new System.Exception("Incorrect tweener usgage! There are unclosed branches!");

            branchStack.Clear();

            (GameObject target, Sequence sequence, BranchType type) branch;
            branch.target = node;
            branch.sequence = DG.Tweening.DOTween.Sequence();
            branch.type = BranchType.Main;

            if (name != "")
                branch.sequence.stringId = name;

            branchStack.Push(branch);
            return instance;
        }

        public static DKSequence CreateBranch(BranchType branchType)
        {
            if (branchStack.Peek().type == BranchType.None)
                throw new System.Exception("Incorrect tween usage! There are no master sequence to branch from!");

            (GameObject target, Sequence sequence, BranchType type) branch;

            branch.target = target;
            branch.sequence = DG.Tweening.DOTween.Sequence();
            branch.type = BranchType.None; //error indicator

            if (branchType == BranchType.Async)
            {
                //Create separateSequense
                branch.type = BranchType.Async;                
            }

            if (branchType == BranchType.Sync)
            {
                //Pause execution of current sequense                
                branch.type = BranchType.Sync;
            }

            branchStack.Push(branch);

            return instance;
        }

        public static void CloseBranch()
        {
            (GameObject target, Sequence sequence, BranchType type) closedBranch = branchStack.Pop();

            closedBranch.sequence.Pause();

            if (closedBranch.type == BranchType.Async)
            {
                Do(() => { closedBranch.sequence.Play(); });
            }

            if (closedBranch.type == BranchType.Sync)
            {
                //sequence.Pause();
                Do(() => {
                    sequence.Pause();
                    closedBranch.sequence.Play();
                });
                closedBranch.sequence.AppendCallback(() => {
                    sequence.Play();
                });
            }
        }
       
        public static void Loop(int count, LoopType type)
        {
            tween = null;
            sequence.SetLoops(count, type);
        }        

        public static void Delay(float time)
        {
            tween = null;
            sequence.AppendInterval(time);
        }

        public static void Delay(float time, TweenCallback callback)
        {
            sequence.AppendInterval(time).AppendCallback(callback);
        }

        public static void Value(float time, float from, float to, DOSetter<float> action)
        {
            tween = DOTween.To(() => from, action, to, time);
            sequence.Append(tween);
        }

        public static void Do(TweenCallback action)
        {
            tween = null;
            sequence.AppendCallback(() => action());
        }

        public static void Complete(System.Action action)
        {
            tween = null;
            sequence.OnComplete(() => action());
        }        

        public static void ApplyParams(TweenParams[] settings)
        {
            for (int i = 0; i < settings.Length; i++)
                settings[i].Apply();
        }
    }
}
