using API__Clean_Template.Domain.DomainBase;

namespace API__Clean_Template.Domain.Entities.InformationOfUser;

public class InformationOfUser : BaseEntity<Guid>
{
    public string? JobService { get; set; }
    public string? Education { get; set; }

    public string? RetirementNumber { get; set; }

    public string? HasSocialSecurity { get; set; }

    public string? DescriptionHasSocialSecurity { get; set; }

    public string? IsGuaranteed { get; set; }

    public string? DescriptionGuaranteed { get; set; }


}
