namespace XomracLabs.Utilities.Extensions
{
    public static class RendererExtensions
    {
        public static void MakeVisible(this Renderer renderer) => renderer.enabled = true;

        public static void MakeInvisible(this Renderer renderer) => renderer.enabled = false;

        public static Vector3 RandomPointInBounds(this Renderer renderer)
        {
            var bounds = renderer.bounds;
            return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z));
    }
    }
}