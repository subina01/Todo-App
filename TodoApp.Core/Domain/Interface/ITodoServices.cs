
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.11.35431.28
MinimumVisualStudioVersion = 10.0.40219.1
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "src", "src", "{CF4D2D10-1B36-4F00-ACE1-8337B9977BBD}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "TodoApp.Core", "TodoApp.Core\TodoApp.Core.csproj", "{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Todo.Infrastructure", "Todo.Infrastructure\Todo.Infrastructure.csproj", "{61A4ED95-C421-48CB-A546-52B6A2E7C360}"
EndProject
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "todo.WebAPI", "ToDo.WebAPI\todo.WebAPI.csproj", "{07A1DA0B-840C-42F7-8C9F-FBC5262E5507}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD}.Debug | Any CPU.ActiveCfg = Debug | Any CPU
		{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD}.Debug | Any CPU.Build.0 = Debug | Any CPU
		{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD}.Release | Any CPU.ActiveCfg = Release | Any CPU
		{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD}.Release | Any CPU.Build.0 = Release | Any CPU
		{61A4ED95-C421-48CB-A546-52B6A2E7C360}.Debug | Any CPU.ActiveCfg = Debug | Any CPU
		{61A4ED95-C421-48CB-A546-52B6A2E7C360}.Debug | Any CPU.Build.0 = Debug | Any CPU
		{61A4ED95-C421-48CB-A546-52B6A2E7C360}.Release | Any CPU.ActiveCfg = Release | Any CPU
		{61A4ED95-C421-48CB-A546-52B6A2E7C360}.Release | Any CPU.Build.0 = Release | Any CPU
		{07A1DA0B-840C-42F7-8C9F-FBC5262E5507}.Debug | Any CPU.ActiveCfg = Debug | Any CPU
		{07A1DA0B-840C-42F7-8C9F-FBC5262E5507}.Debug | Any CPU.Build.0 = Debug | Any CPU
		{07A1DA0B-840C-42F7-8C9F-FBC5262E5507}.Release | Any CPU.ActiveCfg = Release | Any CPU
		{07A1DA0B-840C-42F7-8C9F-FBC5262E5507}.Release | Any CPU.Build.0 = Release | Any CPU
                                EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
		{EC7E53EF-54BC-4E5D-8EBA-71085A88FDFD} = { CF4D2D10 - 1B36 - 4F00 - ACE1 - 8337B9977BBD}
{ 61A4ED95 - C421 - 48CB - A546 - 52B6A2E7C360} = { CF4D2D10 - 1B36 - 4F00 - ACE1 - 8337B9977BBD}
EndGlobalSection



                                GlobalSection(ExtensibilityGlobals) = postSolution

<<<<<<< HEAD
                                                                SolutionGuid = { FD3227B4 - 4BC7 - 48F3 - B8D7 - 2FDAE77E2271}
EndGlobalSection
EndGlobal
=======
{
    public interface ITodoServices
    {

        public  Task<IEnumerable<GetAllTasksResponseDTO>> GetAllTasks();

        public Task<GetAllTaskByIdResponseDTO> GetTaskById(int id);


        public Task AddTask(ToDo tododata);
        public Task<UpdateTaskResponseDTO> UpdateTask(int id, UpdateTaskRequestDTO updateTodoTask);
        public  Task<UpdateStatusResponseDTO> UpdateTaskStatus(int id, UpdateStatusRequestDTO newStatus);
        public Task<DeleteTaskResponseDTO> DeleteTask(int id);
    }
}
>>>>>>> 83c617e (feat(dto):add request and response DTOs for updating, deleting, and retrieving tasks)
