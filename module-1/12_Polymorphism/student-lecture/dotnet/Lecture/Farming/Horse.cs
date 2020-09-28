using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        /// <summary>
        /// Creates a new horse.
        /// </summary>
        /// <param name="name">The name which the horse goes by.</param>
        public Horse() : base("HORSE")
        {
        }

        /// <summary>
        /// The single noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundOnce()
        {
            return "NEIGH";
        }

        /// <summary>
        /// Makes the horse gallup in the field.
        /// This only exists to show you that horses can have their own methods.
        /// </summary>
        public void Gallup()
        {
            // TODO: Implement galloping.
        }
    }
}
