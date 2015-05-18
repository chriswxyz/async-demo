using System.Threading.Tasks;

namespace FunWithAsync
{
    public class ComputeService
    {
        private long Fib(long n)
        {
            if (n < 2)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        public long Compute(long input)
        {
            //Computes the value on the caller's thread, leading to a frozen UI.
            return Fib(input);
        }

        public async Task<long> ComputeBackground(long input)
        {
            //Queue up work to run on the thread pool and immediately return to the caller.
            //This is not 'naturally async', as another thread must be blocked to complete the work.
            return await Task.Run(() => Fib(input));
        }
    }
}