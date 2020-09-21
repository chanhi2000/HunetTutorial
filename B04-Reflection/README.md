# Reflection

## 목표
 - Reflection 응용 (`A-Reflection`)
 

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


## Tip: 인덱스크기의오류

#### 문제 분석


