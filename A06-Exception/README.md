# Exception  

## 목표
 - 예외처리 / 다중 예외처리 (`A-Try`)
 - `finally`문 (`B-TryCatchFinally`)
 - `throw`문 (`C-Throw`)
 - 사용자 `Exception` (`D-UserDefined`)


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


## Tip: 인덱스크기의오류

```cs
namespace 예외처리
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int a = 10;
            int res = 0;

            res = a / i;

            Console.WriteLine("res={0");
        }
    }
}
...
```

```bash
처리 되지 않은 예외 : `System.DivideByZeroException`
위치 : `예외처리.Program.Main(string[] args)`
```

#### 문제 분석
- 컴파일시에 없는 에러가 실행 시에 발생하는 것이며 메세지를 보시면 처리되지 않는 예외를 발생한 것입니다.
- 해결방안: 아래와 같이 try~catch 구문으로 Exception을 구현 후 컴파일 하세요.

```cs
try {
    res = a / i;
} catch (Exception e) {
    Console.WriteLine(e.Message);
}
```


