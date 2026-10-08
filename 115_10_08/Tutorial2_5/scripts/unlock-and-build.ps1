param(
    [string]$ProjectFile = "C:\Users\m303\Documents\GitHub\115_1_C_Sharp\115_10_08\Tutorial2_5\Tutorial2_5.csproj"
)

# 停止同名 process（如果有）
Try {
    Get-Process -Name "Tutorial2_5" -ErrorAction SilentlyContinue | ForEach-Object {
        Write-Host "Stopping process PID $($_.Id) ..."
        Stop-Process -Id $_.Id -Force -ErrorAction SilentlyContinue
    }
} Catch {
    Write-Host "沒有找到名稱為 Tutorial2_5 的 process 或停止失敗。"
}

# 嘗試以 PID 停止（可移除或改為你的 PID）
# Stop-Process -Id 35524 -Force -ErrorAction SilentlyContinue

# 等短暫時間讓系統釋放鎖
Start-Sleep -Milliseconds 500

# 建置
dotnet build $ProjectFile   