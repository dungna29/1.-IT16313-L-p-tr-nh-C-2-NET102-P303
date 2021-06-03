﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_CLASS_GENERIC
{
    class PolyGeneric<T>
    {
        private T[] arrs;//Mảng chưa định kiểu

        public PolyGeneric(int size)
        {
            arrs = new T[size];
        }

        public T[] Arrs
        {
            get => arrs;
            set => arrs = value;
        }
        //Phương thức trả về 1 giá trị trong mảng
        public T GetValueByIndex(int index)
        {
            if (index<0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return arrs[index];
        }

        //Thêm giá trị vào mảng
        public void addValueByIndex(int index, T value)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }

            arrs[index] = value;
        }
    }
}
