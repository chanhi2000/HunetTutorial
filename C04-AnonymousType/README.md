# AnonymousType

## 목표
 - `Var`변수 (`A-Var`)
 - 암시적 배열 선언 (`B-ArrayCreationExp`)
 - 익명 메서드/대리자 (`C-AnonymousMethod`)

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


## Tip: 형변환 관련 오류

```cs
...
namespace 익명Pro
{
    class Var변수
    {
        static void Main(string[] args)
        {
            var a = 100.4;
            int b = a;
            Console.WriteLine("a={0}, b={1}",a, b);
        }
    }
}
```

```bash
암시적으로 'double'형식을 'int'형식으로 변환할 수 없습니다. 명시적 변환이 있습니다. 캐스트가 있는지 확인하십시오.
```

#### 문제 분석
 - 원인: 익명 `var`키워드를 이용해서 지역 변수를 선언했습니다.  상수가 `double` 100.4로 초기화가 되었기 때문에 `int b=a;` 구문형식에서 오류를 발생
 - 해결방법: 익명 키워드로 선언한 지역변수 `a`는 상수에 따라 자료형이 결정되기 때문에 명시형 변환을 하셔야 합니다. `int b = (int)a;` 로 바꾸어서 선언하세요.
