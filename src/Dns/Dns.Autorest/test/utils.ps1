function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id

    # Setup zone, location, resource group
    $env.ResourceGroup = 'dnssecrg'
    $env.Location = 'global'
    $env.ZoneName1 = 'dnstestpowershellsdk1.com'
    $env.ZoneName2 = 'dnstestpowershellsdk2.com'
    $env.ZoneName3 = 'dnstestpowershellsdk3.com'

    Import-Module Az.Dns
    New-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName1
    New-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName2
    New-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName3

    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
    Import-Module Az.Dns
    Remove-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName1 -Confirm:$false
    Remove-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName2 -Confirm:$false
    Remove-AzDnsZone -ResourceGroupName $env.ResourceGroup -Name $env.ZoneName3 -Confirm:$false
}

