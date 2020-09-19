using System;
using System.Threading;

// RegisteredWaitHandle 을 사용하여 대기된 작업을 취소합니다.
// AutoResetEvent 개체는 단일 대기 스레드가 해제된 후 시스템에 의해 자동으로 non-signaled 상대로 재설정됩니다.
// 대기 중인 스레드가 없으면 이벤트 개체는 signaled상태로 계혹 남아 있습니다.
namespace B_ThreadPool
{
    public class TaskInfo
    {
        public RegisteredWaitHandle Handle = null;
        public string OtherInfo = "default";
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            // 대기중인 스레드에게 신호.
            AutoResetEvent ev = new AutoResetEvent(false);

            TaskInfo ti = new TaskInfo();
            ti.OtherInfo = "첫번째";

            ti.Handle = ThreadPool.RegisterWaitForSingleObject(
                ev,     // 작업에 실행 신호
                new WaitOrTimerCallback(waitprocess), // 시간제한 처리 명력ㅇ
                ti,     // 대기된 작업 취소
                1000,   // 1초
                false
            );

            Thread.Sleep(3100);
            Console.WriteLine("싱글메인스레드입니다.");
            ev.Set(); // 대기중인 스레드가 호출될 수 있도록 합니다.
            Thread.Sleep(1000);
        }

        public static void waitprocess(object state, bool timedOut)
        {
            TaskInfo ti = (TaskInfo) state;
            string cause = "TIMED OUT";
            if (timedOut)
            {
                cause = "SIGNALED";
                if (ti.Handle != null) ti.Handle.Unregister(null);
            }
            Console.WriteLine("waitprocess( {0} ) executes on thread {1}: cause = {2}."
                , ti.OtherInfo
                ,Thread.CurrentThread.GetHashCode().ToString()
                , cause
            );
        }
    }
}