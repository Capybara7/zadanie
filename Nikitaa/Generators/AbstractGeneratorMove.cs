// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.AbstractBaseObjects;

namespace ScreenSaverApp.Generators
{
    public abstract class AbstractGeneratorMove<T> : AbstractGenerator<T>
        where T : AbstractMoveImageObject
    {
        public int Speed { get; set; }

        public virtual void Move()
        {
            foreach (var item in Items)
            {
                item.Move();
            }
        }

        public override void Update()
        {
            Items.RemoveAll(x => x.IsEndMove);
            RandomlyAddItem();
        }
    }
}
