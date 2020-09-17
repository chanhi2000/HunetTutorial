# MethodTest

## 목표
 - 메소드 만들기 및 호출
 - 메소드 오버로딩
 - 파라미터의 전달 방법(`in`, `ref`, `out`, `param`)


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
    <Compile Remove="MethodTest1.cs" />
    ...
  </ItemGroup>

  <ItemGroup>
    <None Include="MethodTest1.cs" />
    ...
  </ItemGroup>
...
```