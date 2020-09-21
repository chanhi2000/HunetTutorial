# IO  

## 목표
 - File 읽기 쓰기 (`A-File`)
 - Stream 읽기 쓰기 (`B-StreamRW`)
 - Binary 읽기 쓰기 (`C-Binary`)
 

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


## Tip: 파일 입출력 관련 오류

```cs
try 
{
     // Create an instance of StreamBuilder to read from a file.
     // The using statement also closes the Statement.
     using (StreamReader sr = new StringReader("TestFile2.txt"))
     {
         ...
     }
}
```

```bash
The file could not be red:
`C:\Documents and Settings\Administrator\My Documents\작업\Day09\Resource\입출력\입출력\bin\Debug\TestFile2.txt`
계속 하려면 아무 키나 누르십시오.
```

#### 문제 분석
 - 오류 : `StreamReader("TestFile2.txt")` 파일이 없다는 뜻입니다.
 - 해결 : 경로나 해당 파일이 있는지 찾아봅니다.

