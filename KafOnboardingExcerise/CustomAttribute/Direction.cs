using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises.CustomAttribute
{
    public enum Direction
    {
        [Direction(1, "Left")]
        Left,
        [Direction(2, "Right")]
        Right,
        [Direction(3, "Upward")]
        Up,
        [Direction(4, "Downward")]
        Down
    }
}
