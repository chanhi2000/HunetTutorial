# Collection

## 목표
 - `IList` 인터페이스 (`A-IList`)
 - `ICollection` 인터페이스 (`B-ICollection`)


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


## Tip: 컬렉션 관련 오류

```cs
namespace 컬렉션
{
    public class ArrayTest
    {
        public static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            Console.WriteLine("개수는 ={0} 용량={1}", myAL.Count, myAL.Capacity);
            myAL.Add("1.홍길동");
            myAL.Add("2.정길동");
            myAL.Add("3.황길동");
            myAL.Add("4.이길동");
            Console.WriteLine("개수는 ={0} 용량={1}", myAL.Count, myAL.Capacity);
            
            Prn(myAL);
            Console.WriteLine("3번째 위치에 13소길동 삽입해 봅니다.");
            myAL[5] = "소길동"
            Prn(myAL);
            ...
        }
    }
}
```

```bash
처리되지 않은 예외 : System.ArgumentOutOfRangeException: 인덱스는 음수가 아니어야하며 컬랙션의 크기보다 작아야 합니다.

매개 변수 이름: index
    위치: System.Collections.ArrayList.set_Item
    위치: 컬렉션.ArrayTest.Main(string[] args)
```

#### 문제 분석
 - 원인: `Add()`로 자료를 추가하면서 용량의 index 0부터 3까지 할당한 후 할당되지 않는 4번지 소길동을 입력해서 발생하는 오류입니다.
 - 해결: `myAL[4]`로 인덱스를 바꾸면 오류가 해결됩니다.
