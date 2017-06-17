using System;
using System.Collections;

//인터페이스(7) (223p ~ 224p)
namespace Ex030
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            foreach(USB usb in notebook)
            {
                Console.WriteLine(usb);
            }
        }
    }

    class Hardware { }

    class USB
    {
        string name;
        
        public USB(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }

    //IEnumerable 인터페이스 구현
    class Notebook : Hardware, IEnumerable
    {
        USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

        //IEnumerator를 구현한 열거자 인스턴스 반환
        public IEnumerator GetEnumerator()
        {
            return new USBEnumerator(usbList);
        }

        //중첩 클래스로 정의된 열거자 타입
        public class USBEnumerator : IEnumerator
        {
            int pos = -1;
            int length = 0;
            object[] list;

            public USBEnumerator(USB[] usb)
            {
                list = usb;
            }

            //현재 요소를 반환하도록 약속된 접근자 메서드
            public object Current
            {
                get { return list[pos]; }
            }

            //다음 순서의 요소를 지정하도록 약속된 메서드
            public bool MoveNext()
            {
                if(pos > length)
                {
                    return false;
                }

                pos++;
                return true;
            }

            //처음부터 열거하고 싶을 때 호출하면 되는 메서드
            public void Reset()
            {
                pos = -1;
            }
        }
    }
}