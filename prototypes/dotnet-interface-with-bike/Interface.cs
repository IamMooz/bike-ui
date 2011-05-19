using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;

namespace Timbii.BIKEUI.Prototypes.DotNetInterface
{
    class Interface
    {
        [DllImport("Core.dll", EntryPoint = "?createToolkit@@YA?AV?$shared_ptr@VIBikeToolkit@@@boost@@ABV?$list@V?$basic_string@_WU?$char_traits@_W@std@@V?$allocator@_W@2@@std@@V?$allocator@V?$basic_string@_WU?$char_traits@_W@std@@V?$allocator@_W@2@@std@@@2@@std@@@Z")]
        extern public static void createToolkit(String[] something);

        [DllImport("Core.dll", EntryPoint = "?endBulkUpdate@IStorageBackend@@UAEXXZ")]
        extern public static void endBulkUpdate(String[] something);
    }
}
