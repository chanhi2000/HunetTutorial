# App

## 목표
 - 성적표 출력 응용프로그램 (`ScoreProject`)

### 처리 조건
 - 세 과목을 배열로 선언하고 총점과 평균을 계산할 수 있어야 함.
 - 계산된 총점을 이용해 학점을 열거형으로 선언계산 가능해야 함.
 - 출력 시 번호와 이름, 세 과목 총점 및 평균학점, 학점 및 순위를 각각 출력할 수 있게 대리자를 선언해서 출력함.
 - 3의 조건을 만족하는 클래스를 상속받아 과목을 추가하여 4과목의 총점, 평균, 학점 및 순위를 구하는 파생클래스를 작성함.
 - 객체생성 시, 배열로 선언되고 넘겨진 객체를 이용하여 순위를 구할 수 있어야 함.
 - 성적처리를 DLL로 작성된 컴포넌트를 참조하여 값을 전달, 결과값을 쉽게 구할 수 있어야 함.
 
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