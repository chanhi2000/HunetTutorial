# Thread

## 목표
 - Thread 생성 및 소멸 (`A-Thread`)
 - ThreadPool 의 사용 (`B-ThreadPool`)
 - Thread 일시 중지 및 삭제 (`C-ThreadInterrupt`)
 - 동기화 작업 (`D-Sync`)
 - 비동기화 작업 (`E-Async`)

## `dotnet` 실행어

### `dotnet new sln`
솔루션 서식 생성

### `dotnet sln add ...${프로젝트이름}.csproj`
솔루션에 프로젝트 추가 

### `dotnet build ${SLN파일}.sln`
솔루션에 모두 포함되어 있는 대상 모듈 컴파일 후 실행 

### `dotnet new console`
콘솔용 애플리케이션 생성

### `dotnet run`
컴파일 후 실행

### `*.csproj` 파일에서 컴파일 대상에서 제외

```xml
...
  <ItemGroup>
    <Compile Remove="InheritEx1.cs" />
    ...
  </ItemGroup>

  <ItemGroup>
    <None Include="InheritEx1.cs" />
    ...
  </ItemGroup>
...
```

## Tip: 멀티 스레드 관련오류

```cs
...
static TimeSpan waitTime = new TimeSpan(0, 0, 1);

public static void Main()
{
    Thread newThread1 = new Thread(new ThreadStart(Work));
    Thread newThread = new Thread(new ThreadStart(Work));
    newThread.Start();
    newThread1.Start();

    newThread.Abort();
    newThread1.Start();
}
```

```bash
처리되지 않은 예외: System.Threading.ThreadStateException: 스레드가 실행 중이거나 종료다.
    위치: System.Threading.Thread.StartupSetApartmentStateInternal()
    위치: System.Threading.Thread.Start()
    위치: Test.ThreadExample.Main() 파일 C:\야용이\Test\Test\Program.cs: 줄 25
```

#### 문제 분석
 - 원인: `Thread`의 멀티실행의 경우 한 스레드가 공유 메서드를 호출 시, 그 메서드 지원을 다 쓸 때까지 다른 쓰레드는 사용못하고 대기합니다. 24 줄에서 실행 하고 있는 쓰레드를 `Abort`를 호출하면 다시 시작되었다가 중단되겠지요? 이미 21줄에서 실행을 하고 있는 `Abort`를 만나면 `new Thread`실행이 될 때 까지 대기하는 것을 다시 시작하려는 명령을 주는 상황이니 실행 중이라고 메세지를 주는 것입니다.
- 해결 : 해당 메서드 사용을 마쳤는지 확인하기 위해 `Join` 메소드를 사용합니다. `Join`은 스레드가 종료될 때까지 호출 스레드를 차단합니다. 이후에 다른 스레드가 같은 메서드를 사용할수 있게 됩니다.



