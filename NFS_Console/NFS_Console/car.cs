using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Car
    {
        private string model;
        private int speed;

        public void SetModel(string model_)
        {
            model_ = model;
        }

        public string GetModel()
        {
            return model_;
        }

        public void SetSpeed (int speed_)
        {
            speed_ = speed;
        }
    }
}
