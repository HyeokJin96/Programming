using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Say();
            parent.Run();
            parent.walk();

            Child child = new Child();
            child.Say();
            child.Run();
            child.walk();

            StoreButton storeButton = new StoreButton();
            storeButton.onClickButton();

            QuestButton questButton = new QuestButton();
            questButton.onClickButton();

        }       //  Main

        public void Override()
        {
            /**
             * 메서드 오버라이드
             * 부모 클래스에 만든 메서드를 자식 클래스에서 다시 새롭게 만들어 사용하는 것을 메서드 오버라이드라고 한다.
             * 
             * 메서드 오버라이드 : 재정의
             * 클래스 관계를 따지는 상속 개념에서 부모 클래스에 이미 만든 메서드를 동일한 이름으로
             * 자식 클래스에서 다시 정의해서 사용한다는 개념이 메서드 오버라이드라고 한다.
             *  - 메서드 오버라이드는 메서드를 새롭게 정의하는 것
             *  - 오버라이드(Override), 오버라이딩(Overriding)이라는 표현은 동일하다.
             *  - 부모 클래스의 Virtual 키워드로 선언해 놓은 메서드는 자식 클래스에서 override 키워드로 재정의해서 사용 가능하다.
             *  
             *  메서드 오버로드와 오버라이드
             *  처음 프로그래밍할 때 쉽게 혼동하는 단어가 바로 오버로드(Overload)와 오버라이드(Override)이다.
             *  오버로드는 여러 번 정의하는 것이고, 오버라이드는 다시 정의하는 것이다.
             */
        }       //  Override
    }       // class Program

    public class Parent
    {
        protected int number = 100;

        public virtual void Say()
        {
            Console.WriteLine("[부모] 안녕하세요.");
        }
        public virtual void Run()
        {
            Console.WriteLine("[부모] 달리다.");
        }
        public virtual void walk()
        {
            Console.WriteLine("[부모] 걷다.");
        }

        public virtual void walk(int count)
        {
            Console.WriteLine("[부모 ]{0}번 걷다.");
        }
        public virtual void walk(string where_)
        {
            Console.WriteLine("[부모] {0}에서 걷다.");
        }
    }       //  clss Parent

    public class Child : Parent
    {
        public override void Say()
        {
            Console.WriteLine("[자식] 안녕하세요.");
        }
        public override void Run()
        {
            base.Run();
            this.number = 10;
            Console.WriteLine("number: {0}", number);
        }
        public override void walk()
        {
            Console.WriteLine("[자식] 걷다.");
        }

        public override void walk(int count)
        {
            Console.WriteLine("[자식] {0}번 걷다.");
        }
        public override void walk(string where_)
        {
            Console.WriteLine("[자식] {0}에서 걷다.");
        }
    }       //  class Child

    public class Button
    {
        protected int _index = 0;

        public virtual void onClickButton()
        {
            Console.WriteLine("{0}번 버튼을 눌렀음", this._index);
        }
    }       //  class Button

    public class StoreButton : Button
    {
        public override void onClickButton()
        {
            _index = 1;

            base.onClickButton();

            Console.WriteLine("이 버튼을 누르면 상점 창이 열림", _index);
        }
    }       //  class StoreButton

    public class QuestButton : Button
    {
        public override void onClickButton()
        {
            _index = 2;

            base.onClickButton();

            Console.WriteLine("이 버튼을 누르면 퀘스트 창이 열림", _index);
        }
    }       // class QuestButton
}