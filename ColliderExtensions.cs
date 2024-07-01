namespace XomracLabs.Utilities.Extensions
{
    public static class ColliderExtensions
    {
        public static void EnableCollisions(this Collider collider) => collider.enabled = true;

        public static void DisableCollisions(this Collider collider) => collider.enabled = false;
    }
}