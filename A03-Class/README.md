# Class

## 목표
 - 클래스 정의 (`AddList`)
 - 엑세스 한정자 개념 (`AccessTest`)
 - 메모리 관리 (`MemMgmt`)
    - 생성 
    - 사용 
    - 소멸
 - 가비지 수집 (`DescontructorTest`)

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