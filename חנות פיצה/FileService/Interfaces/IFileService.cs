  namespace FileService;
  public interface IFileService<T>
  {
    List<T> Read();
    void Write(T obj);
  }