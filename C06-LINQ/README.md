# LINQ

## 목표
 - 표현식 `from`, `where`, `select` (`A-SelectBasic`)
 - 표현식 `group`, `into`, `order by` (`B-SelectAdvanced`)
 - 표현식 `join`, `let`, 표준쿼리연산자 (`C-QueryOp`)
 
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
   static void Main()
   {
       List<string> names = new List<string> {"홍길동", "정길동", "박길동", "이길동"};
       IEnumerable<string> Nic = from name in names
          where name[0] == '정';
      foreach(string str in Nic)
      {
          Console.WriteLine(str);
      }

   }
```

```bash
쿼리 본문은 `select`절 또는 `group`절로 끝나야 합니다.
```

#### 문제 분석
 - 원인: 표준쿼리 식을 규칙에 맞게 작성하지 않아서 발생하였습니다. 
 - 해결방법: 표준쿼리식은 `select` 또는 `group`절로 끝나야 하며, 16라인 종결자 앞에 `select name`을 반드시 명시하셔야 합니다.
