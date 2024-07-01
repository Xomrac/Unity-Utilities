namespace XomracLabs.Utilities.Extensions
{
    public static class AnimatorExtensions
    {
         public static float CurrentAnimationLength(this Animator animator, int layerIndex=0)
        {
            return animator.GetCurrentAnimatorStateInfo(layerIndex).length;
        }
    }
}