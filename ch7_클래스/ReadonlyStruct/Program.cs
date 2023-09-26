using System;

namespace ReadonlyStruct
{
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0); //생성자를 이용하면 지정가능
            Red.G = 100; //읽기전용이므로 수정불가 -> 컴파일 에러
        }
    }
}