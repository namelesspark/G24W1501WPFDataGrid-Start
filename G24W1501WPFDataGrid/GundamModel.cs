
namespace G24W1501WPFDataGrid;

public class GundamModel
{
    public GundamModel(string name, string model, string party) =>  //s는 비주얼 스튜디오의 기본 키워드 / S는 .NET의 클래스
        (Name, Model, Party) = (name, model, party);

    public string Name { get; }
    public string Model { get; }
    public string Party { get; }


}
