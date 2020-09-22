# Overloading

## 목표
 - 연산자 오버로딩 선언 (`A-Opeartor`)
 - 연산자 오버로딩 활용 (`B-LogicalOperator`)
 - 형변환 연산자 오버로딩 (`C-Conversion`)
 - 컬렉션을 활용한 연산자 (`D-Comparison`)

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


## Tip: 오버로딩 관련 오류

```cs
...
        public static void Main(string[] args)
        {
           Test dig = new Test(7);

           double num = dig;

           Test dig2 = 12;
           System.Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);
           string str = "ab";
           dig2 = str;
           System.Console.WriteLine("num = {0} dig2 = {1}", str, dig2.v);
            ...
        }
    }
}
```

```bash
임시적으로 'string'형식을 '연산자오버로딩.Test' 형식으로 변환할 수 없습니다.
```

#### 문제 분석
 - 원인: 연산자 overloading은 명시적변환과 묵시형변환을 구현합니다.  대입자료형 (string)이 암시적인 형변환이 불가능합니다.
 - 결과: `Double`의 자료형 보다 작은 자료형의 값과 형을 입력해서 묵시형 변환을 하셔야 합니다.
