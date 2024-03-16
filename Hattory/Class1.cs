using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattory
{
    internal class FpsShower
    {
        private static DateTime lastTime;
        private static int fps = 0;
        private static int frames = 0;
        /// <summary>
        /// Должен ли показываться счётчик ФПС?
        /// </summary>
        public static bool ShouldRender { get; set; } = true;

        public static int FPS
        {
            get
            {
                Update();
                return fps;
            }
        }
        private static void Update()
        {
            if ((DateTime.Now - lastTime).TotalMilliseconds >= 500)
            {
                lastTime = DateTime.Now;
                fps = frames * 2;
                frames = 0;
            }
            frames++;
        }
    }
}
