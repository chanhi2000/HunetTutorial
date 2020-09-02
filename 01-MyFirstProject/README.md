# MyFirstProject

## 목표
 - 콘솔을 이용하여 '안녕하세요?' 를 출력
 - 하나의 솔루션 프로젝트에 2개 이상의 프로젝트를 관리


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


## 내용

### `*.csproj` 파일에서 컴파일 대상에서 제외

```xml
...
  <ItemGroup>
    <Compile Remove="Program.cs" />
  </ItemGroup>

  <ItemGroup>
    <None Include="Program.cs" />
  </ItemGroup>
...
```


## Tip: 인덱스크기의오류

```cs
namepace MyProject
{
    class Class1
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("{0} {1} {2}", 100, 200, 300);
            Console.WriteLine("{0} {1} {2}", 100, 200);
            Console.WriteLine("{0}{1}", 100, 200, 300);
        }
    }

}
```

```bash
처리되지 않은 예외: System.FormatException: 0에서 시작하는 인덱스는 0보다 크거나 같아야 하며 인수 목록의 크기보다 작아야 합니다.
```

#### 문제 분석
- `Console.WriteLine("format flag", 인수)`
- `flag`의 인덱스와 인수의 위치는 인수목록의 크기가 작아야 합니다.
- 15라인 (__i.e.__ `Console.WriteLine("{0} {1} {2}", 100, 200)`)은 인덱스는 0, 1, 2 까지있는데 목록은 0(100), 1(200) 밖에 없어서 오류가 납니다.
- 17라인은 오류가 나지 않습니다. 이유는 인덱스가 목록보다 작기 때문에 100과 200만 출력합니다.
