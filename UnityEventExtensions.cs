namespace XomracLabs.Utilities.Extensions
{
    public static class UnityEventExtensions
    {
         public static void SetListener(this UnityEvent unityEvent, UnityAction action)
        {
            unityEvent.RemoveAllListeners();
            unityEvent.AddListener(action);
        }
    
        public static void SetListeners(this UnityEvent unityEvent, List<UnityAction> actions)
        {
            unityEvent.RemoveAllListeners();
            foreach (var action in actions)
            {
                unityEvent.AddListener(action);
            }
        }
    }
}