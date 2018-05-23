using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocMag.Forms {
    interface IForm {
        string ScreenName { get; } 
        void Update();
    }
}
