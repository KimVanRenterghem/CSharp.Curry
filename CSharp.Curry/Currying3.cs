using System;

namespace CSharp.Curry
{
    public static class Currying3
    {
        public static Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f)
            => in1
            => in2
            => in3
            => f(in1, in2, in3);

        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn1 in1)
            => in2
            => in3
            => f(in1, in2, in3);

        public static Func<TIn2, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn1 in1, _ n, _ n1)
            => in2
            => in3
            => f(in1, in2, in3);

        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn2 in2)
            => in1
            => in3
            => f(in1, in2, in3);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, _ n, TIn2 in2)
            => in1
            => in3
            => f(in1, in2, in3);
        public static Func<TIn1, Func<TIn3, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, _ n, TIn2 in2, _ n1)
            => in1
            => in3
            => f(in1, in2, in3);

        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn3 in3)
            => in1
            => in2
            => f(in1, in2, in3);

        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, _ n, TIn3 in3)
            => in1
            => in2
            => f(in1, in2, in3);

        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, _ n, _ n2, TIn3 in3)
            => in1
            => in2
            => f(in1, in2, in3);

        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn1 in1, TIn2 in2)
            => in3
            => f(in1, in2, in3);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn2 in2, TIn3 in3)
            => in1
            => f(in1, in2, in3);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, _ n, TIn2 in2, TIn3 in3)
            => in1
            => f(in1, in2, in3);


        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn1 in1, TIn3 in3)
            => in2
            => f(in1, in2, in3);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, TIn2, TIn3, TOut> f, TIn1 in1, _ n, TIn3 in3)
            => in2
            => f(in1, in2, in3);

        public static Func<TIn1, TIn2, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f)
            => (in1, in2, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn2, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1)
            => (in2, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn2, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, _ n, _ n1)
            => (in2, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn2 in2)
            => (in1, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, _ n, TIn2 in2)
            => (in1, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, _ n, TIn2 in2, _ n1)
            => (in1, in3)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn3 in3)
            => (in1, in2)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, _ n, _ n1, TIn3 in3)
            => (in1, in2)
            => f(in1)(in2)(in3);

        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, TIn2 in2)
            => (in3)
            => f(in1)(in2)(in3);

        public static Func<TIn3, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, TIn2 in2, _ n)
            => (in3)
            => f(in1)(in2)(in3);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, TIn3 in3)
            => (in2)
            => f(in1)(in2)(in3);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, _ n, TIn3 in3)
            => (in2)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn2 in2, TIn3 in3)
            => (in1)
            => f(in1)(in2)(in3);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, _ n, TIn2 in2, TIn3 in3)
            => (in1)
            => f(in1)(in2)(in3);

        public static TOut Curry<TIn1, TIn2, TIn3, TOut>(this Func<TIn1, Func<TIn2, Func<TIn3, TOut>>> f, TIn1 in1, TIn2 in2, TIn3 in3)
            => f(in1)(in2)(in3);
    }
}
