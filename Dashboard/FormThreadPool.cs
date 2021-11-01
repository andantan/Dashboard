using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard
{
    class FormThreadPool
    {
        private static List<Thread> Pool;

        static FormThreadPool()
        {
            Pool = new List<Thread>();
        }

        public static void AddThreadToPool(Thread thread)
        {
            // 실행되는 모든 쓰레드를 Pool에 추가합니다.

            Pool.Add(thread);
        }

        public static void KillThreadAll()
        {
            // 실행된 모든 쓰레드에게 ThreadAbortException을 발생시킵니다.
            // 후에 무한 루프를 빠져나오며 쓰레드를 안전하게 종료합니다.

            foreach (Thread thread in Pool)
            {
                thread.Abort();
            }
        }
    }
}
