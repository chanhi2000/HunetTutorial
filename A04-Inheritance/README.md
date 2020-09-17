# Inheritance

## 목표
 - 단일상속 (`A-InheritEx`)
 - 다형성 (`Polymorphism`)
     - `new`
     - `override`
 - 최종 (`Sealed`)
 - 추상화 (`Abstract`)
 - 인터페이스 (`Interface`)

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
namepace 상속.단일상속
{
    class 상속
    {
        public static void Main(String[] args)
        {
            Test2 t = new Test2();
            Test2 t1 = new Test2(100, 200);'
        }
    }

}
```

```bash
'<전역 네임스페이스>' 네임스페이스에 이미 '상속'에 대한 정의가 들어 있습니다.
```

#### 문제 분석
- namespace와 class와 이름이 같다.
- namespace는 class를 포함 구역을 정해주는 블럭이다.
- class이름과 namespace이름이 같다면 참조 할 수 없다.
- class이름을 다시 정의하고 컴파일

