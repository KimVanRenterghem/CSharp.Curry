using System;

namespace CSharp.Curry
{
    public static class Currying2
    {
        public static Func<TIn1, Func<TIn2, TOut>> Curry<TIn1, TIn2, TOut>(this Func<TIn1, TIn2, TOut> f)
            => in1
            => in2
            => f(in1, in2);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, TIn2, TOut> f, TIn1 in1)
            => in2
            => f(in1, in2);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, TIn2, TOut> f, TIn1 in1, _ n)
            => in2
            => f(in1, in2);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, TIn2, TOut> f, TIn2 in2)
            => in1
            => f(in1, in2);
        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, TIn2, TOut> f, _ n, TIn2 in2)
            => in1
            => f(in1, in2);

        public static Func<TIn1, TIn2, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f)
            => (in1, in2)
            => f(in1)(in2);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f, TIn1 in1)
            => (in2)
            => f(in1)(in2);

        public static Func<TIn2, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f, TIn1 in1, _ n)
            => (in2)
            => f(in1)(in2);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f, TIn2 in2)
            => (in1)
            => f(in1)(in2);

        public static Func<TIn1, TOut> Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f, _ n, TIn2 in2)
            => (in1)
            => f(in1)(in2);

        public static TOut Curry<TIn1, TIn2, TOut>(this Func<TIn1, Func<TIn2, TOut>> f, TIn1 in1, TIn2 in2)
            => f(in1)(in2);
    }
}
