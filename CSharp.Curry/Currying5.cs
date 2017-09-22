using System;

namespace CSharp.Curry
{
    public static class Currying5
    {
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f)
            => in1
            => in2
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn2, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1)
            => in2
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, _ n1, _ n2, _ n3)
            => in2
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2)
            => in1
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2)
            => in1
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, _ n1, _ n2, _ n3)
            => in1
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn1, Func<TIn2, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn3 in3)
            => in1
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3)
            => in1
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn4, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, _ n2, _ n3)
            => in1
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn4 in4)
            => in1
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, _ n2, TIn4 in4)
            => in1
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn5, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, _ n2, TIn4 in4, _ n3)
            => in1
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn5 in5)
            => in1
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, Func<TIn4, TOut>>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, _ n2, _ n3, TIn5 in5)
            => in1
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);


        public static Func<TIn3, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2)
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn3, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, _ n, _ n1, _ n2)
            => in3
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn3 in3)
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3)
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, _ n1, _ n2)
            => in2
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn4 in4)
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n1, _ n2, TIn4 in4)
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n1, _ n2, TIn4 in4, _ n)
            => in2
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn5 in5)
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, _ n1, _ n2, TIn5 in5)
            => in2
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn1, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn3 in3)
            => in1
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3)
            => in1
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn4, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, _ n1, _ n2)
            => in1
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn4 in4)
            => in1
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn4 in4)
            => in1
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, _ n1, TIn4 in4)
            => in1
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, _ n1, TIn4 in4, _ n2)
            => in1
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn5 in5)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn5 in5)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, _ n1, _ n2, TIn5 in5)
            => in1
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn3 in3, TIn4 in4)
            => in1
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, TIn4 in4)
            => in1
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn5, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, TIn4 in4, _ n2)
            => in1
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn3 in3, TIn5 in5)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, TIn5 in5)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn4, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, _ n2, TIn5 in5)
            => in1
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn4 in4, TIn5 in5)
            => in1
            => in2
            => in3
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, _ n2, TIn4 in4, TIn5 in5)
            => in1
            => in2
            => in3
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn4, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3)
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);


        public static Func<TIn4, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3, _ n, _ n1)
            => in4
            => in5
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn3, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn4 in4)
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn3, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, _ n, TIn4 in4)
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn3, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, _ n, TIn4 in4, _ n1)
            => in3
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn5 in5)
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn3, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, _ n, _ n1, TIn5 in5)
            => in3
            => in4
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn2, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn3 in3, TIn4 in4)
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, TIn4 in4)
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, TIn4 in4, _ n1)
            => in2
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn3 in3, TIn5 in5)
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, TIn5 in5)
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, _ n1, TIn5 in5)
            => in2
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn4 in4, TIn5 in5)
            => in2
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, _ n1, TIn4 in4, TIn5 in5)
            => in2
            => in3
            => f(in1, in2, in3, in4, in5);

        public static Func<TIn1, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn3 in3, TIn4 in4)
            => in1
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, TIn4 in4)
            => in1
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn5, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, TIn4 in4, _ n1)
            => in1
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn3 in3, TIn5 in5)
            => in1
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, TIn5 in5)
            => in1
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn4, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, _ n1, TIn5 in5)
            => in1
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn4 in4, TIn5 in5)
            => in1
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn4 in4, TIn5 in5)
            => in1
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, _ n1, TIn4 in4, TIn5 in5)
            => in1
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn3 in3, TIn4 in4, TIn5 in5)
            => in1
            => in2
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, _ n1, TIn3 in3, TIn4 in4, TIn5 in5)
            => in1
            => in2
            => f(in1, in2, in3, in4, in5);


        public static Func<TIn5, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3, TIn4 in4)
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3, TIn5 in5)
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn4 in4, TIn5 in5)
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn3 in3, TIn4 in4, TIn5 in5)
            => in2
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn2 in2, TIn3 in3, TIn4 in4, TIn5 in5)
            => in1
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn5, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3, TIn4 in4, _ n)
            => in5
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn4, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, TIn3 in3, _ n, TIn5 in5)
            => in4
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, TIn2 in2, _ n, TIn4 in4, TIn5 in5)
            => in3
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, TIn1 in1, _ n, TIn3 in3, TIn4 in4, TIn5 in5)
            => in2
            => f(in1, in2, in3, in4, in5);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> f, _ n, TIn2 in2, TIn3 in3, TIn4 in4, TIn5 in5)
            => in1
            => f(in1, in2, in3, in4, in5);
    }
}
