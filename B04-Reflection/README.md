# Reflection

## 목표
 - Reflection 응용 (`A-Reflection`)
 - Attribute 응용 (`B-Attribute`)


## 인덱서 와 프로퍼티의 차이


## `dotnet` 실행어

### `dotnet new sln`
솔루션 서식 생성

### `dotnet sln add ...${프로젝트이름}.csproj`
솔루션에 프로젝트 추가 

### `dotnet build ${SLN파일}.sln`
솔루션에 모두 포함되어 있는 대상 모듈 컴파일 후 실행 

### `dotnet new console`
콘솔용 애플리케이션 생성

### `dotnet new classlib`
클래스 라이브러리 생성

### `dotnet add ${프로젝트이름}.csproj reference ${클래스 라이브러리 프로젝트 파일}.csproj`
현 프로젝트에 클래스 라이브러리 레퍼런스 추가

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


## Tip: Attribvute 관련 오류

```cs
namespace Reflection과Attribute.Attribute
{
    class attributeTest
    {
        [conditional("Debugging")]
        public static void DebugPrint()
        {
            Console.WriteLine("Debugging Now");
        }

        public static void Main(string[] args)
        {
            DebugPrint();
        }
    }
}
```

```bash
 'conditional' 형식 또는 네임스페이스 이름을 찾을 수 없습니다. using 지시문 또는 어셈블리 참조가 있는지 확인하십시오.
 'conditionalAttribute' 형식 또는 네임스페이스 이름을 찾을 수 없습니다. using 지시문 또는 어셈블리 참조가 있는지 확인하십시오.
```

#### 문제 분석
 - `using System.Diagnostics;` 네임스페이스를 쓴 후 코드를 작성하고 컴파일 해 본 후, `프로젝트 속성` > `빌드` > `조건부컴파일기호` 에 Conditional의 스트링 값을 똑같이 적고 다시 `컴파일` > 결과를 볼수 있습니다.

