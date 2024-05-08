/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

namespace XLua.LuaDLL
{

    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using XLua;

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN || XLUA_GENERAL || (UNITY_WSA && !UNITY_EDITOR)
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int lua_CSFunction(IntPtr L);

#if GEN_CODE_MINIMIZE
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int CSharpWrapperCaller(IntPtr L, int funcidx, int top);
#endif
#else
    public delegate int lua_CSFunction(IntPtr L);

#if GEN_CODE_MINIMIZE
    public delegate int CSharpWrapperCaller(IntPtr L, int funcidx, int top);
#endif
#endif


    public partial class Lua
	{
#if (UNITY_IPHONE || UNITY_TVOS || UNITY_WEBGL || UNITY_SWITCH) && !UNITY_EDITOR
        const string LUADLL = "__Internal";
#else
        const string LUADLL = "xlua";
#endif

        [MonoPInvokeCallback(typeof(XLuaBase.lua_CSFunction))]
        public static int LoadLpeg(System.IntPtr L)
        {
            return XLuaBase.Lua.luaopen_lpeg(L);
        }

        [MonoPInvokeCallback(typeof(XLuaBase.lua_CSFunction))]
        public static int LoadluaPbc(System.IntPtr L)
        {
            return XLuaBase.Lua.luaopen_protobuf_c(L);
        }

        public static IntPtr lua_tothread(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_tothread(L, index);
        }

        public static int xlua_get_lib_version()
        {
            return XLuaBase.Lua.xlua_get_lib_version();
        }

        public static int lua_gc(IntPtr L, LuaGCOptions what, int data)
        {
            return XLuaBase.Lua.lua_gc(L, (XLuaBase.LuaGCOptions)what, data);
        }

        public static IntPtr lua_getupvalue(IntPtr L, int funcindex, int n)
        {
            return XLuaBase.Lua.lua_getupvalue(L, funcindex, n);
        }

        public static IntPtr lua_setupvalue(IntPtr L, int funcindex, int n)
        {
            return XLuaBase.Lua.lua_setupvalue(L, funcindex, n);
        }

        public static int lua_pushthread(IntPtr L)
        {
            return XLuaBase.Lua.lua_pushthread(L);
        }

        public static int lua_setfenv(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_setfenv(L, stackPos);
        }

        public static IntPtr luaL_newstate()
        {
            return XLuaBase.Lua.luaL_newstate();
        }

        public static void lua_close(IntPtr L)
        {
            XLuaBase.Lua.lua_close(L);
        }

        public static uint xlua_objlen(IntPtr L, int stackX)
        {
            return XLuaBase.Lua.xlua_objlen(L, stackX);
        }

        public static void luaopen_xlua(IntPtr L)
        {
            XLuaBase.Lua.luaopen_xlua(L);
        }

        public static void luaL_openlibs(IntPtr L)
        {
            XLuaBase.Lua.luaL_openlibs(L);
        }

        public static void lua_createtable(IntPtr L, int narr, int nrec)
        {
            XLuaBase.Lua.lua_createtable(L, narr, nrec);
        }

        public static void lua_settop(IntPtr L, int stackPos)
        {
             XLuaBase.Lua.lua_settop(L, stackPos);
        }

        public static void lua_insert(IntPtr L, int stackPos)
        {
             XLuaBase.Lua.lua_insert(L, stackPos);
        }

        public static void lua_remove(IntPtr L, int stackPos)
        {
             XLuaBase.Lua.lua_remove(L, stackPos);
        }

        public static int lua_rawget(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_rawget(L, stackPos);
        }

        public static void lua_rawset(IntPtr L, int stackPos)
        {
             XLuaBase.Lua.lua_rawset(L, stackPos);
        }

        public static int lua_setmetatable(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_setmetatable(L, stackPos);
        }

        public static int lua_rawequal(IntPtr L, int index1, int index2)
        {
            return XLuaBase.Lua.lua_rawequal(L, index1, index2);
        }

        public static void lua_pushvalue(IntPtr L, int stackPos)
        {
            XLuaBase.Lua.lua_pushvalue(L, stackPos);
        }

        public static void lua_pushcclosure(IntPtr L, IntPtr fn, int n)
        {
            XLuaBase.Lua.lua_pushcclosure(L, fn, n);
        }

        public static void lua_replace(IntPtr L, int stackPos)
        {
            XLuaBase.Lua.lua_replace(L, stackPos);
        }

        public static int lua_gettop(IntPtr L)
        {
            return XLuaBase.Lua.lua_gettop(L);
        }

        public static LuaTypes lua_type(IntPtr L, int stackPos)
        {
            return (LuaTypes)XLuaBase.Lua.lua_type(L, stackPos);
        }

        public static bool lua_isnumber(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_isnumber(L, stackPos);
        }

        public static int luaL_ref(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.luaL_ref(L, stackPos);
        }

        public static void luaL_unref(IntPtr L, int stackPos, int r)
        {
             XLuaBase.Lua.luaL_unref(L, stackPos, r);
        }

        public static bool lua_isstring(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_isstring(L, stackPos);
        }

        public static bool lua_isinteger(IntPtr L, int stackPos)
        {
            return XLuaBase.Lua.lua_isinteger(L, stackPos);
        }

        public static void lua_pushnil(IntPtr L)
        {
            XLuaBase.Lua.lua_pushnil(L);
        }

        public static IntPtr lua_atpanic(IntPtr L, XLuaBase.lua_CSFunction panicf)
        {
            return XLuaBase.Lua.lua_atpanic(L, panicf);
        }

        public static void lua_pushnumber(IntPtr L, double stackPos)
        {
            XLuaBase.Lua.lua_pushnumber(L, stackPos);
        }

        public static void lua_pushboolean(IntPtr L, bool stackPos)
        {
            XLuaBase.Lua.lua_pushboolean(L, stackPos);
        }

        public static int luaL_newmetatable(IntPtr L, string meta)
        {
            return XLuaBase.Lua.luaL_newmetatable(L, meta);
        }

        public static int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc)
        {
            return XLuaBase.Lua.lua_pcall(L, nArgs, nResults, errfunc);
        }

        public static double lua_tonumber(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_tonumber(L, index);
        }

        public static bool lua_toboolean(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_toboolean(L, index);
        }

        public static IntPtr lua_topointer(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_topointer(L, index);
        }

        public static IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen)
        {
            return XLuaBase.Lua.lua_tolstring(L, index, out strLen);
        }

        public static bool lua_checkstack(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_checkstack(L, index);
        }

        public static int lua_next(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_next(L, index);
        }

        public static void lua_pushlightuserdata(IntPtr L, IntPtr index)
        {
            XLuaBase.Lua.lua_pushlightuserdata(L, index);
        }

        public static int luaopen_i64lib(IntPtr L)
        {
            return XLuaBase.Lua.luaopen_i64lib(L);
        }

        public static int luaopen_socket_core(IntPtr L)
        {
            return XLuaBase.Lua.luaopen_socket_core(L);
        }

        public static void lua_pushint64(IntPtr L, long n)
        {
            XLuaBase.Lua.lua_pushint64(L, n);
        }

        public static void lua_pushuint64(IntPtr L, ulong n)
        {
            XLuaBase.Lua.lua_pushuint64(L, n);
        }

        public static bool lua_isint64(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_isint64(L, index);
        }

        public static bool lua_isuint64(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_isuint64(L, index);
        }

        public static long lua_toint64(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_toint64(L, index);
        }

        public static ulong lua_touint64(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_touint64(L, index);
        }

        public static IntPtr lua_touserdata(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_touserdata(L, index);
        }

        public static void luaL_where(IntPtr L, int level)
        {
            XLuaBase.Lua.luaL_where(L, level);
        }

        public static void lua_newtable(IntPtr L) //[-0, +0, m]
        {
            lua_createtable(L, 0, 0);
        }

        public static bool lua_isfunction(IntPtr L, int stackPos)
        {
            return lua_type(L, stackPos) == LuaTypes.LUA_TFUNCTION;
        }

        public static bool lua_istable(IntPtr L, int stackPos)
        {
            return lua_type(L, stackPos) == LuaTypes.LUA_TTABLE;
        }

        public static bool lua_isthread(IntPtr L, int stackPos)
        {
            return lua_type(L, stackPos) == LuaTypes.LUA_TTHREAD;
        }

        public static int luaL_error(IntPtr L, string message) //[-0, +1, m]
        {
            xlua_csharp_str_error(L, message);
            return 0;
        }

        public static int xlua_getglobal(IntPtr L, string name)
        {
            return XLuaBase.Lua.xlua_getglobal(L, name);
        }

        public static int xlua_setglobal(IntPtr L, string name)
        {
            return XLuaBase.Lua.xlua_setglobal(L, name);
        }

        public static void xlua_getloaders(IntPtr L)
        {
            XLuaBase.Lua.xlua_getloaders(L);
        }

        public static void lua_pop(IntPtr L, int amount)
        {
            lua_settop(L, -(amount) - 1);
        }

        public static bool lua_isnil(IntPtr L, int index)
        {
            return (lua_type(L, index) == LuaTypes.LUA_TNIL);
        }

        public static bool lua_isboolean(IntPtr L, int index)
        {
            return lua_type(L, index) == LuaTypes.LUA_TBOOLEAN;
        }

        public static int luaL_ref(IntPtr L) //[-1, +0, m]
        {
            return luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
        }

        public static void xlua_rawgeti(IntPtr L, int tableIndex, long index)
        {
            XLuaBase.Lua.xlua_rawgeti(L, tableIndex, index);
        }

        public static void xlua_rawseti(IntPtr L, int tableIndex, long index)
        {
            XLuaBase.Lua.xlua_rawseti(L, tableIndex, index);
        }

        public static void lua_getref(IntPtr L, int reference)
        {
            xlua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, reference);
        }

        public static int pcall_prepare(IntPtr L, int error_func_ref, int func_ref)
        {
            return XLuaBase.Lua.pcall_prepare(L, error_func_ref, func_ref);
        }

        public static void lua_unref(IntPtr L, int reference)
        {
            luaL_unref(L, LuaIndexes.LUA_REGISTRYINDEX, reference);
        }

        public static void lua_pushstdcallcfunction(IntPtr L, XLuaBase.lua_CSFunction function, int n = 0) //[-0, +1, m]
        {
            XLuaBase.Lua.lua_pushstdcallcfunction(L, function, n);
        }

        public static int xlua_upvalueindex(int n)
        {
            return XLuaBase.Lua.xlua_upvalueindex(n);
        }

        public static int xlua_tointeger(IntPtr L, int index)
        {
            return XLuaBase.Lua.xlua_tointeger(L, index);
        }

        public static uint xlua_touint(IntPtr L, int index)
        {
            return XLuaBase.Lua.xlua_touint(L, index);
        }

        public static string lua_tostring(IntPtr L, int index)
        {
            return XLuaBase.Lua.lua_tostring(L, index);
        }

        public static void xlua_pushinteger(IntPtr L, int value)
        {
            XLuaBase.Lua.xlua_pushinteger(L, value);
        }

        public static void xlua_pushuint(IntPtr L, uint value)
        {
            XLuaBase.Lua.xlua_pushuint(L, value);
        }

#if NATIVE_LUA_PUSHSTRING
       public static void lua_pushstring(IntPtr L, string str)
		{
return XLuaBase.Lua.lua_pushstring(L, str);
}
#else
        public static void lua_pushstring(IntPtr L, string str) //业务使用
        {
            if (str == null)
            {
                lua_pushnil(L);
            }
            else
            {
#if !THREAD_SAFE && !HOTFIX_ENABLE
                if (Encoding.UTF8.GetByteCount(str) > InternalGlobals.strBuff.Length)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(str);
                    xlua_pushlstring(L, bytes, bytes.Length);
                }
                else
                {
                    int bytes_len = Encoding.UTF8.GetBytes(str, 0, str.Length, InternalGlobals.strBuff, 0);
                    xlua_pushlstring(L, InternalGlobals.strBuff, bytes_len);
                }
#else
                var bytes = Encoding.UTF8.GetBytes(str);
                xlua_pushlstring(L, bytes, bytes.Length);
#endif
            }
        }
#endif

        public static void xlua_pushlstring(IntPtr L, byte[] str, int size)
        {
            XLuaBase.Lua.xlua_pushlstring(L, str, size);
        }

        public static void xlua_pushasciistring(IntPtr L, string str) // for inner use only
        {
            if (str == null)
            {
                lua_pushnil(L);
            }
            else
            {
#if NATIVE_LUA_PUSHSTRING
                lua_pushstring(L, str);
#else
#if !THREAD_SAFE && !HOTFIX_ENABLE
                int str_len = str.Length;
                if (InternalGlobals.strBuff.Length < str_len)
                {
                    InternalGlobals.strBuff = new byte[str_len];
                }

                int bytes_len = Encoding.UTF8.GetBytes(str, 0, str_len, InternalGlobals.strBuff, 0);
                xlua_pushlstring(L, InternalGlobals.strBuff, bytes_len);
#else
                var bytes = Encoding.UTF8.GetBytes(str);
                xlua_pushlstring(L, bytes, bytes.Length);
#endif
#endif
            }
        }

        public static void lua_pushstring(IntPtr L, byte[] str)
        {
            if (str == null)
            {
                lua_pushnil(L);
            }
            else
            {
                xlua_pushlstring(L, str, str.Length);
            }
        }

        public static byte[] lua_tobytes(IntPtr L, int index) //[-0, +0, m]
        {
            return XLuaBase.Lua.lua_tobytes(L, index);
        }

        public static int xlua_pgettable(IntPtr L, int idx)
        {
            return XLuaBase.Lua.xlua_pgettable(L, idx);
        }

        public static int xlua_psettable(IntPtr L, int idx)
        {
            return XLuaBase.Lua.xlua_psettable(L, idx);
        }

        public static void luaL_getmetatable(IntPtr L, string meta)
        {
            xlua_pushasciistring(L, meta);
            lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
        }

        public static int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name)
        {
            return XLuaBase.Lua.xluaL_loadbuffer(L, buff, size, name);
        }

        public static int luaL_loadbuffer(IntPtr L, string buff, string name) //[-0, +1, m]
        {
            byte[] bytes = Encoding.UTF8.GetBytes(buff);
            return xluaL_loadbuffer(L, bytes, bytes.Length, name);
        }

        public static int xlua_tocsobj_safe(IntPtr L, int obj)
        {
            return XLuaBase.Lua.xlua_tocsobj_safe(L, obj);
        }

        public static int xlua_tocsobj_fast(IntPtr L, int obj)
        {
            return XLuaBase.Lua.xlua_tocsobj_fast(L, obj);
        }

        public static int lua_error(IntPtr L)
        {
            xlua_csharp_error(L);
            return 0;
        }

        public static IntPtr xlua_tag()
        {
            return XLuaBase.Lua.xlua_tag();
        }

        public static int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref)
        {
            return XLuaBase.Lua.xlua_tryget_cachedud(L, key, cache_ref);
        }

        public static void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref)
        {
            XLuaBase.Lua.xlua_pushcsobj(L, key, meta_ref, need_cache, cache_ref);
        }

        public static int gen_obj_indexer(IntPtr L)
        {
            return XLuaBase.Lua.gen_obj_indexer(L);
        }

        public static int gen_obj_newindexer(IntPtr L)
        {
            return XLuaBase.Lua.gen_obj_newindexer(L);
        }

        public static int gen_cls_indexer(IntPtr L)
        {
            return XLuaBase.Lua.gen_cls_indexer(L);
        }

        public static int gen_cls_newindexer(IntPtr L)
        {
            return XLuaBase.Lua.gen_cls_newindexer(L);
        }

        public static int get_error_func_ref(IntPtr L)
        {
            return XLuaBase.Lua.get_error_func_ref(L);
        }

        public static int load_error_func(IntPtr L, int Ref)
        {
            return XLuaBase.Lua.load_error_func(L, Ref);
        }

        public static void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n)
        {
            XLuaBase.Lua.xlua_push_csharp_function(L, fn, n);
        }

        public static int xlua_csharp_str_error(IntPtr L, string message)
        {
            return XLuaBase.Lua.xlua_csharp_str_error(L, message);
        }

        public static int xlua_csharp_error(IntPtr L)
        {
            return XLuaBase.Lua.xlua_csharp_error(L);
        }

        public static bool xlua_pack_int8_t(IntPtr buff, int offset, byte field)
        {
            return XLuaBase.Lua.xlua_pack_int8_t(buff, offset, field);
        }

        public static bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field)
        {
            return XLuaBase.Lua.xlua_unpack_int8_t(buff, offset, out field);
        }

        public static bool xlua_pack_int16_t(IntPtr buff, int offset, short field)
        {
            return XLuaBase.Lua.xlua_pack_int16_t(buff, offset, field);
        }

        public static bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field)
        {
            return XLuaBase.Lua.xlua_unpack_int16_t(buff, offset, out field);
        }

        public static bool xlua_pack_int32_t(IntPtr buff, int offset, int field)
        {
            return XLuaBase.Lua.xlua_pack_int32_t(buff, offset, field);
        }

        public static bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field)
        {
            return XLuaBase.Lua.xlua_unpack_int32_t(buff, offset, out field);
        }

        public static bool xlua_pack_int64_t(IntPtr buff, int offset, long field)
        {
            return XLuaBase.Lua.xlua_pack_int64_t(buff, offset, field);
        }

        public static bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field)
        {
            return XLuaBase.Lua.xlua_unpack_int64_t(buff, offset, out field);
        }

        public static bool xlua_pack_float(IntPtr buff, int offset, float field)
        {
            return XLuaBase.Lua.xlua_pack_float(buff, offset, field);
        }

        public static bool xlua_unpack_float(IntPtr buff, int offset, out float field)
        {
            return XLuaBase.Lua.xlua_unpack_float(buff, offset, out field);
        }

        public static bool xlua_pack_double(IntPtr buff, int offset, double field)
        {
            return XLuaBase.Lua.xlua_pack_double(buff, offset, field);
        }

        public static bool xlua_unpack_double(IntPtr buff, int offset, out double field)
        {
            return XLuaBase.Lua.xlua_unpack_double(buff, offset, out field);
        }

        public static IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref)
        {
            return XLuaBase.Lua.xlua_pushstruct(L, size, meta_ref);
        }

        public static void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref)
        {
            XLuaBase.Lua.xlua_pushcstable(L, field_count, meta_ref);
        }

        public static int xlua_gettypeid(IntPtr L, int idx)
        {
            return XLuaBase.Lua.xlua_gettypeid(L, idx);
        }

        public static int xlua_get_registry_index()
        {
            return XLuaBase.Lua.xlua_get_registry_index();
        }

        public static int xlua_pgettable_bypath(IntPtr L, int idx, string path)
        {
            return XLuaBase.Lua.xlua_pgettable_bypath(L, idx, path);
        }

        public static int xlua_psettable_bypath(IntPtr L, int idx, string path)
        {
            return XLuaBase.Lua.xlua_psettable_bypath(L, idx, path);
        }

        //对于Unity，仅浮点组成的struct较多，这几个api用于优化这类struct
        public static bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2)
        {
            return XLuaBase.Lua.xlua_pack_float2(buff, offset, f1, f2);
        }

        public static bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2)
        {
            return XLuaBase.Lua.xlua_unpack_float2(buff, offset, out f1, out f2);
        }

        public static bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3)
        {
            return XLuaBase.Lua.xlua_pack_float3(buff, offset, f1, f2, f3);
        }

        public static bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3)
        {
            return XLuaBase.Lua.xlua_unpack_float3(buff, offset, out f1, out f2, out f3);
        }

        public static bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4)
        {
            return XLuaBase.Lua.xlua_pack_float4(buff, offset, f1, f2, f3, f4);
        }

        public static bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3,
            out float f4)
        {
            return XLuaBase.Lua.xlua_unpack_float4(buff, offset, out f1, out f2, out f3, out f4);
        }


        public static bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4,
            float f5)
        {
            return XLuaBase.Lua.xlua_pack_float5(buff, offset, f1, f2, f3, f4, f5);
        }

        public static bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3,
            out float f4, out float f5)
        {
            return XLuaBase.Lua.xlua_unpack_float5(buff, offset, out f1, out f2, out f3, out f4, out f5);
        }

        public static bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4,
            float f5, float f6)
        {
            return XLuaBase.Lua.xlua_pack_float6(buff, offset, f1, f2, f3, f4, f5, f6);
        }

        public static bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3,
            out float f4, out float f5, out float f6)
        {
            return XLuaBase.Lua.xlua_unpack_float6(buff, offset, out f1, out f2, out f3, out f4, out f5, out f6);
        }

        public static bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec)
        {
            return XLuaBase.Lua.xlua_pack_decimal(buff, offset, ref dec);
        }

        public static bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign,
            out int hi32, out ulong lo64)
        {
            return XLuaBase.Lua.xlua_unpack_decimal(buff, offset, out scale, out sign, out hi32, out lo64);
        }

        public static bool xlua_is_eq_str(IntPtr L, int index, string str)
        {
            return xlua_is_eq_str(L, index, str, str.Length);
        }

        public static bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len)
        {
            return XLuaBase.Lua.xlua_is_eq_str(L, index, str, str_len);
        }

        public static IntPtr xlua_gl(IntPtr L)
        {
            return XLuaBase.Lua.xlua_gl(L);
        }

#if GEN_CODE_MINIMIZE
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void xlua_set_csharp_wrapper_caller(IntPtr wrapper);

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void xlua_push_csharp_wrapper(IntPtr L, int wrapperID);

        public static void xlua_set_csharp_wrapper_caller(CSharpWrapperCaller wrapper_caller)
        {
#if XLUA_GENERAL || (UNITY_WSA && !UNITY_EDITOR)
            GCHandle.Alloc(wrapper);
#endif
            xlua_set_csharp_wrapper_caller(Marshal.GetFunctionPointerForDelegate(wrapper_caller));
        }
#endif
    }
}
