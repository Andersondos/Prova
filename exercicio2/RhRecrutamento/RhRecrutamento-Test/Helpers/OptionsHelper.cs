using RhRecrutamento.Helpers;
using Microsoft.Extensions.Options;

namespace RhRecrutamento_Test.Helpers
{
	public class OptionsHelper : IOptions<AppSettings>
	{
		AppSettings IOptions<AppSettings>.Value => new AppSettings()
		{
			Secret = "adasd dadasdadasdadsd ad sdd ak dajsk dajdkasdjaskdlkj"
		};
	}
} 