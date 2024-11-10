using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLGameLib
{
    public class BoardController
    {
        private int[,] _maskContainer;
        
        public BoardController()
        {
            _maskContainer = new int[32, 5];
            Initialize();
        }

        private void Initialize()
        {

        }

        public static bool TryGetMaskValueByName(string name, Type mask, out int value)
        {
            bool result = false;
            value = 0;
            string[] masks = Enum.GetNames(mask).ToArray();
            int[] values = (int[])Enum.GetValues(mask);

            for (int i = 0; i < masks.Length; i++)
            {
                if (masks[i].Equals(name))
                {
                    value = values[i];
                    result = true;
                    break;
                }

            }

            return result;
        }

        public static bool TryGetMaskNameByValue(int value, Type mask, out string name)
        {
            bool result = false;
            name = string.Empty;
            string[] masks = Enum.GetNames(mask).ToArray();
            int[] values = (int[])Enum.GetValues(mask);

            for (int i = 0; i < masks.Length; i++)
            {
                if (values[i].Equals(value))
                {
                    name = masks[i];
                    result = true;
                    break;
                }

            }

            return result;
        }

    }
}
