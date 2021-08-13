# Power Apps component framework

Empowers professional developers and app makers to create code components for model-driven and canvas apps.

### Package code component

1. Create `/Solutions` folder

2. ```powershell
   cd ./Solutions
   ```

3. ```powershell
   pac solution init --publisher-name developer --publisher-prefix dev
   ```

4. ```powershell
   pac solution add-reference --path ..
   ```

5. ```powershell
   msbuild /t:build /restore
   ```

Generated solution files in `\bin\debug\`


