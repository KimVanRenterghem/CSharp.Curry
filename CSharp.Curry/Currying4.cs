using System;

namespace CSharp.Curry
{
    public static class Currying4
    {
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f)
            => in1
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1)
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, _ n2, _ n3, _ n4)
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn2 in2)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, _ n3, _ n4)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn3 in3)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, _ n2, TIn3 in3)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, _ n2, TIn3 in3, _ n4)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn4 in4)
            => in1
            => in2
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, _ n2, _ n3, TIn4 in4)
            => in1
            => in2
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2)
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2, _ n3, _ n4)
            => in3
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn3 in3)
            => in2
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, _ n2, TIn3 in3)
            => in2
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, _ n2, TIn3 in3, _ n4)
            => in2
            => in4
            => f(in1, in2, in3, in4);


        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn4 in4)
            => in2
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, _ n2, _ n3, TIn4 in4)
            => in2
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn2 in2, TIn3 in3)
            => in1
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, TIn3 in3)
            => in1
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, TIn3 in3, _ n4)
            => in1
            => in4
            => f(in1, in2, in3, in4);


        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn2 in2, TIn4 in4)
            => in1
            => in3
            => f(in1, in2, in3, in4);


        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, TIn4 in4)
            => in1
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, _ n3, TIn4 in4)
            => in1
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, _ n2, TIn3 in3, TIn4 in4)
            => in1
            => in2
            => f(in1, in2, in3, in4);

        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn3 in3, TIn4 in4)
            => in1
            => in2
            => f(in1, in2, in3, in4);


        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3)
            => in4
            => f(in1, in2, in3, in4);
        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3,_ n4)
            => in4
            => f(in1, in2, in3, in4);

        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2, TIn4 in4)
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn2 in2, _ n3, TIn4 in4)
            => in3
            => f(in1, in2, in3, in4);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, TIn3 in3, TIn4 in4)
            => in2
            => f(in1, in2, in3, in4);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn1 in1, _ n2, TIn3 in3, TIn4 in4)
            => in2
            => f(in1, in2, in3, in4);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, TIn2 in2, TIn3 in3, TIn4 in4)
            => in1
            => f(in1, in2, in3, in4);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TOut> f, _ n1, TIn2 in2, TIn3 in3, TIn4 in4)
            => in1
            => f(in1, in2, in3, in4);

        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1)
            => (in2)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, _ n2, _ n3, _ n4)
            => (in2)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn2 in2)
            => (in1)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2)
            => (in1)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, _ n3, _ n4)
            => (in1)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn3 in3)
            => (in1)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, _ n2, TIn3 in3)
            => (in1)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, _ n2, TIn3 in3, _ n4)
            => (in1)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn4 in4)
            => (in1)
            => (in2)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, _ n2, _ n3, TIn4 in4)
            => (in1)
            => (in2)
            => (in3)
            => f(in1)(in2)(in3)(in4);

        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2, _ n3, _ n4)
            => (in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn3 in3)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, _ n2, TIn3 in3)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, _ n2, TIn3 in3, _ n4)
            => (in2)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn4 in4)
            => (in2)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, _ n2, _ n3, TIn4 in4)
            => (in2)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn2 in2, TIn3 in3)
            => (in1)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, TIn3 in3)
            => (in1)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, TIn3 in3, _ n4)
            => (in1)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn2 in2, TIn4 in4)
            => (in1)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, TIn4 in4)
            => (in1)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, _ n3, TIn4 in4)
            => (in1)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn3 in3, TIn4 in4)
            => (in1)
            => (in2)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, _ n2, TIn3 in3, TIn4 in4)
            => (in1)
            => (in2)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2, TIn3 in3)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2, TIn3 in3, _ n4)
            => (in4)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2, TIn4 in4)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn2 in2, _ n3, TIn4 in4)
            => (in3)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, TIn3 in3, TIn4 in4)
            => (in2)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn1 in1, _ n2, TIn3 in3, TIn4 in4)
            => (in2)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, TIn2 in2, TIn3 in3, TIn4 in4)
            => (in1)
            => f(in1)(in2)(in3)(in4);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> f, _ n1, TIn2 in2, TIn3 in3, TIn4 in4)
            => (in1)
            => f(in1)(in2)(in3)(in4);
    }
}
