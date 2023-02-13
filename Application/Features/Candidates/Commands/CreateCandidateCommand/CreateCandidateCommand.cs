using Application.Wrappers;
using Domain.Entities;
using MediatR;

namespace Application.Features.Candidates.Commands.CreateCandidateCommand
{
    public class CreateCandidateCommand : IRequest<Response<int>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Client { get; set; }
        public string Phone { get; set; }
        public string Recrutier { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string EducationLevel { get; set; }
        public string CurrentPosition { get; set; }
        public float SalaryExpectations { get; set; }
        public float CurrentSalaryGross { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Notes { get; set; }
        //public List<Language> Languages { get; set; }
    }

    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, Response<int>>
    {
        public async Task<Response<int>> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
