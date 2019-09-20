using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;

using DG.Tweening;
using DG.Tweening.Core;

namespace DK.Tweening
{
    public partial class SequenceMaster
    {
        public static Sequence sequence => branchStack.Peek().sequence;
        private static bool SequenceAutoKill = true;

        internal static readonly DKSequence instance;

        internal static GameObject target => branchStack.Peek().target;
        internal static DKTweener tweener { get; private set; }

        internal static Dictionary<Sequence, int> monitoring = new Dictionary<Sequence, int>(50);

        static Branch branch => branchStack.Peek();

        static Stack<Branch> branchStack = new Stack<Branch>(5);
        
        public static Tween tween { get; private set; }

        internal class Branch
        {
            internal enum Mode { None, Main, Sync, Async }

            internal Branch(GameObject _target)
            {
                target = _target;
                sequence = DG.Tweening.DOTween.Sequence();
                mode = Mode.None;

                asyncBranchCount = 0;
            }

            internal GameObject target;
            internal Sequence sequence;
            internal Mode mode;

            internal int asyncBranchCount;
        }

        static SequenceMaster()
        {
            instance = new DKSequence();
        }

        internal static DKSequence CreateSequence(GameObject node, string name = "", bool keepAlive = true)
        {
            if (branchStack.Count > 1)
                throw new System.Exception("Incorrect tweener usage! There are unclosed branches! Contact DK_Framework developer ASAP!");

            Branch branch = new Branch(node);
            branch.mode = Branch.Mode.Main;
            branch.sequence.SetAutoKill(SequenceAutoKill = !keepAlive);

            tweener = node.GetComponent<DKTweener>();

            if (name != "")
                branch.sequence.stringId = name;

            branchStack.Clear();
            branchStack.Push(branch);

            return instance;
        }

        internal static DKSequence CreateBranch(Branch.Mode branchMode)
        {
            if (IsMasterSequenceAwalible() == false)
                throw new System.Exception("Incorrect tween usage! There are no master sequence to branch from!");

            bool IsMasterSequenceAwalible() 
            {
                // TODO make protection more reliable
                // can be broken by:
                // - creating branch after creating sequence
                if (branchStack.Count > 0)
                    return (branchStack.Peek().mode != Branch.Mode.None);
                else
                    return false;
            }

            Branch branch = new Branch(target);
            branch.sequence.SetId(sequence.stringId); //give all branches same name to simplify control
            branch.mode = branchMode;

            if (branchMode == Branch.Mode.Async)
                branchStack.Peek().sequence.SetAutoKill(SequenceAutoKill);

            branchStack.Push(branch);

            return instance;
        }

        public static void CloseBranch()
        {
            Branch closedBranch = branchStack.Pop();
            Branch currentBranch = branchStack.Peek();

            closedBranch.sequence.Pause();

            if (closedBranch.mode == Branch.Mode.Async)
            {
                Do(() => { closedBranch.sequence.Play(); });
                sequence.onKill += () => {
                    if (closedBranch.sequence.IsComplete())
                        closedBranch.sequence.Kill();
                    else
                        closedBranch.sequence.SetAutoKill(true);
                };
                if (SequenceAutoKill == false)
                {
                    currentBranch.asyncBranchCount++;
                    closedBranch.sequence.onKill += () => {
                        currentBranch.asyncBranchCount--;
                        if (currentBranch.asyncBranchCount == 0)
                            currentBranch.sequence.Kill();
                    };
                }
            }
            else if (closedBranch.mode == Branch.Mode.Sync)
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
