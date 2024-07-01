namespace XomracLabs.Utilities.Extensions
{
    public static class ButtonExtensions
    {
        public static void SetListener(this Button button, UnityAction action)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(action);
        }

       
    
        public static void SetListeners(this Button button, List<UnityAction> actions)
        {
            button.onClick.RemoveAllListeners();
            foreach (var action in actions)
            {
                button.onClick.AddListener(action);
            }
        }
    }
}