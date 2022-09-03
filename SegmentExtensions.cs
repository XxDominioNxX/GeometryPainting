using System.Collections.Generic;
using System.Drawing;
using GeometryTasks;

namespace GeometryPainting
{
    public static class SegmentExtension
    {
        static Dictionary<Segment, Color> Context = new Dictionary<Segment, Color>();
        public static Color GetColor(this Segment seg)
        {
            return Context.ContainsKey(seg) ? Context[seg] : Color.Black;
        }

        public static void SetColor(this Segment seg, Color color)
        {
            var awda = Context.ContainsKey(seg);
            if (Context.ContainsKey(seg))
            {
                Context[seg] = color;
            }
            else
            {
                Context.Add(seg, color);
            }
        }
    }
}
