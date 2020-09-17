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
...
tp2 = delegate(double d)
{
    Consle.WriteLine("d="+ d);
}
tp2(90.8);
..
```

```bash
매배 변수 형식이 대리자 매개 변수 형식과 일치 않으므로 무명 메서드를(을) 대리자 형식 '대리자와이벤트.대리자.Testp'(으)로 변환할 수 없습니다.
'1' 매개 변수가 'double' 형식으로 선언되었지만 'string'형식이어야 합니다.
'대리자와이벤트.대리자.Testp' 대리자에 잘못된 인수가 있습니다.
'1' 인수: 'double' 에서 'string'(으)로 변환할 수 없습니다.
```

#### 문제 분석
- 4개의 오류를 발생하는 것은 첫 번째 오류 메세지에 첫 줄에 선언된 tp2라는 대리자의 원형이 double가 없다는 것.
- `Pt2 = delegate(double d)`
- 두 번째 오류는 선언된 `double`는 없고 `String` 형식을 받는 매개 변수가 있는데 형식이 잘못되었다고 나는 에러입니다. 따라서 형변환이되지 않기 때문에 세 번째와 네 번째 오류가 나는 것입니다.
- 선언된 대리자에 전달되는 값과 무명 메소드의 매개 인자는 대리자의 원형과 일치해야 합니다.


