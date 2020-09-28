# ExtensionPartialMethod

## 목표
 - 확장메소드 (`A-ExtensionMethod`)
 - 파샬메소드 (`B-PartialMethod`)
 - 컬랙션 선언 (`C-CollectionInitializer`)
 - 람다식 (`D-LambdaExp`)
 
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


## Tip: 자동속성 관련 오류

```cs
...
    public string Name
    {
        get;
        private set;
    }

    class AutoPropertyTest
    {
        public static void Main(string[] args)
        {
            addredss ar = new address();
            ar.Name = "홍길동";
            ...
        }
    }
```

```bash
set 접근자에 엑세스 할 수 었음으로 'AutoPro.addrress.Name' 속성 또는 인덱서는 이 컨텍스트에서 사용할 수 없습니다.
```

#### 문제 분석
 - 원인: 선언된 자동 속성부분에 `private set;`으로 선정하면 `read-only`가 되기 때문에 33라인에서 값을 전달하지 못합니다.  23라인에서 선언된 `get`허용 속성 때문에 값을 리턴만 받을 수 있습니다. 자동속성 `read-only`는 호출 및 사용할 수 없는 `private`입니다.
 - 해결방법: `ar.Name`을 사용하기 위해서는 `private`을 제거 하고 `read-only`로 사용하기 위해서는 `ar.Name="홍길동`을 제거합니다.
