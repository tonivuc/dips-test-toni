using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace android_cloud_test.Logic
{
    public class Names
    {
        List<String> names;

        public Names(List<String> names)
        {
            this.names = names;
        }

        public Names()
        {
            names = new List<String>();
        }

        public String AddName(String name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            names.Add(name);
            return names[names.Count - 1];
        }
    }
}
