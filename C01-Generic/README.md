# Generic

## 목표
 - `Generic` 클래스 (`A-Generic`)
 - `Generic` 배열 클래스 (`B-GenericOther`)
 - `Generic` 컬랙션 클래스 (`C-GenericCollection`)



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


## Tip: 제네릭 관련 오류

```cs
namespace 제네릭
{
    public class 제네릭 컬렉션
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("11", "월요일");
            openWith.Add("22", "화요일");
            openWith.Add("33", "수요일");
            openWith.Add("44", "목요일");
            openWith.Add(1, 3);
            
            ...
        }
    }
}
```

```bash
'System.Collections.Generic.Dictionary<string, string>.Add(string, string)' 에 가장 일치하는 오버로드 된 메서드에 잘못된 인수가 있습니다.
'1' 인수 : 'int'에서 'string'으로 변환할 수 없습니다.
'2' 인수 : 'int'에서 'string'으로 변환할 수 없습니다.
```

#### 문제 분석
 - 원인: 선언타입을 `<string, string>`으로 선언했기 때문에 키 값과 value값이 `string`, `string`형으로 들어갑니다. `<int, int>`형식은 변환 오류가 발생합니다.
 - 해결: 전체 선언타입을 바꾸거나, 대입하는 값을 `Add(string, string)` 타입에 맞추는 것입니다.
