using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;
using DG.Tweening.Core;

namespace DK.Tweening
{
    public partial class SequenceMaster
    {
        public enum BranchType { None, Main, Sync, Async }

        public static readonly DKSequence instance;

        public static GameObject target => branchStack.Peek().target;
        public static DKTweener tweener { get; private set; }
        public static Sequence sequence => branchStack.Peek().sequence;

        private static Stack<Branch> branchStack = new Stack<Branch>(5);
        
        public static Tween tween { get; private set; }

        static BranchType lastBranchType = BranchType.None;
        
        struct Branch
        {
            public Branch(GameObject _target)
            {
                target = _target;
                sequence = DG.Tweening.DOTween.Sequence();
                type = BranchType.None;
            }

            public GameObject target;
            public Sequence sequence;
            public BranchType type;
        }

        static SequenceMaster()
        {
            instance = new DKSequence();
        }

        public static DKSequence CreateSequence(GameObject node, string name = "")
        {
            if (branchStack.Count > 1)
                throw new System.Exception("Incorrect tweener usage! There are unclosed branches! Contact DK_Framework developer ASAP!");

            branchStack.Clear();

            Branch branch = new Branch(node);
            lastBranchType = branch.type = BranchType.Main;
            tweener = node.GetComponent<DKTweener>();

            if (name != "")
                branch.sequence.stringId = name;

            branchStack.Push(branch);
            
            return instance;
        }

        public static DKSequence CreateBranch(BranchType branchType)
        {                        
            if (IsMasterSequenceAwalible() == false)
                throw new System.Exception("Incorrect tween usage! There are no master sequence to branch from!");

            bool IsMasterSequenceAwalible() 
            {
                // TODO make protection more reliable
                // can be broken by:
                // - creating branch after creating sequence
                if (branchStack.Count > 0)
                {
                    BranchType stackTopType = branchStack.Peek().type;
                    if (stackTopType == BranchType.None)
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }

            Branch branch = new Branch(target);
            branch.sequence.SetId(sequence.stringId); //give all branches same name to simplify control
            lastBranchType = branch.type = branchType;

            branchStack.Push(branch);

            return instance;
        }

        public static void CloseBranch()
        {
            Branch closedBranch = branchStack.Pop();

            closedBranch.sequence.Pause();

            if (closedBranch.type == BranchType.Async)
            {
                closedBranch.sequence.SetAutoKill(false);
                Do(() => { closedBranch.sequence.Play(); });
                sequence.onKill += () => closedBranch.sequence.Kill();
            }
            else if (closedBranch.type == BranchType.Sync)
            {
                sequence.Append(closedBranch.sequence);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Loop(int count, LoopType type)
        {
            tween = null;
            sequence.SetLoops(count, type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Delay(float time)
        {
            tween = null;
            sequence.AppendInterval(time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Delay(float time, TweenCallback callback)
        {
            sequence.AppendInterval(time).AppendCallback(callback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Value(float time, float from, float to, DOSetter<float> action)
        {
            tween = DOTween.To(() => from, action, to, time);
            sequence.Append(tween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Do(TweenCallback action)
        {
            tween = null;
            sequence.AppendCallback(() => action());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Complete(System.Action action)
        {
            tween = null;
            sequence.OnComplete(() => action());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ApplyParams(ITweenParam[] settings)
        {
            for (int i = 0; i < settings.Length; i++)
                settings[i].Apply();
        }
    }
}
