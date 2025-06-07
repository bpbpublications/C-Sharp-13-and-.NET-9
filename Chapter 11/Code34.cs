using Microsoft.AspNetCore.DataProtection;

.. .
builder.Services.AddDataProtection();
.. .
static void SomeMethod(IDataProtectionProvider provider)
{
    var protector = provider.CreateProtector("MyPurpose");
    string protectedPayload = protector.Protect("Hello World!");
    string unprotectedPayload = protector.Unprotect(protectedPayload);
}