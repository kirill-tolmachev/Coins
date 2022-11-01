using Config;
using UnityEngine;

namespace Extensions
{
    internal static class MiscExtensions
    {
        public static Vector2 ClampToRect(this Vector2 value, Rect rect)
        {
            float x = Mathf.Clamp(value.x, rect.xMin, rect.xMax);
            float y = Mathf.Clamp(value.y, rect.yMin, rect.yMax);

            return new Vector2(x, y);
        }

        public static Rect GetArenaBounds(this IConfig config)
        {
            var playerSize = new Vector2(1f, 1f);

            return new Rect(
                -config.ArenaSizeX / 2f + playerSize.x / 2f,
                -config.ArenaSizeY / 2f + playerSize.y / 2f,
                config.ArenaSizeX - playerSize.x,
                config.ArenaSizeY - playerSize.y);
        }
    }
}
