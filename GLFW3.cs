using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.GLFW3;

public partial struct GLFWmonitor
{
}

public partial struct GLFWwindow
{
}

public partial struct GLFWcursor
{
}

public partial struct GLFWvidmode
{
    public int width;

    public int height;

    public int redBits;

    public int greenBits;

    public int blueBits;

    public int refreshRate;
}

public unsafe partial struct GLFWgammaramp
{
    [NativeTypeName("unsigned short *")]
    public ushort* red;

    [NativeTypeName("unsigned short *")]
    public ushort* green;

    [NativeTypeName("unsigned short *")]
    public ushort* blue;

    [NativeTypeName("unsigned int")]
    public uint size;
}

public unsafe partial struct GLFWimage
{
    public int width;

    public int height;

    [NativeTypeName("unsigned char *")]
    public byte* pixels;
}

public unsafe partial struct GLFWgamepadstate
{
    [NativeTypeName("unsigned char[15]")]
    public fixed byte buttons[15];

    [NativeTypeName("float[6]")]
    public fixed float axes[6];
}

public unsafe partial struct GLFWallocator
{
    [NativeTypeName("GLFWallocatefun")]
    public delegate* unmanaged[Cdecl]<nuint, void*, void*> allocate;

    [NativeTypeName("GLFWreallocatefun")]
    public delegate* unmanaged[Cdecl]<void*, nuint, void*, void*> reallocate;

    [NativeTypeName("GLFWdeallocatefun")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> deallocate;

    public void* user;
}

public static unsafe partial class GLFW3
{
    private const string libglfw3 = "glfw";

    [DllImport(libglfw3)]
    public static extern int glfwInit();

    [DllImport(libglfw3)]
    public static extern void glfwTerminate();

    [DllImport(libglfw3)]
    public static extern void glfwInitHint(int hint, int value);

    [DllImport(libglfw3)]
    public static extern void glfwInitAllocator([NativeTypeName("const GLFWallocator *")] GLFWallocator* allocator);

    [DllImport(libglfw3)]
    public static extern void glfwGetVersion(int* major, int* minor, int* rev);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetVersionString();

    [DllImport(libglfw3)]
    public static extern int glfwGetError([NativeTypeName("const char **")] sbyte** description);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWerrorfun")]
    public static extern delegate* unmanaged[Cdecl]<int, sbyte*, void> glfwSetErrorCallback([NativeTypeName("GLFWerrorfun")] delegate* unmanaged[Cdecl]<int, sbyte*, void> callback);

    [DllImport(libglfw3)]
    public static extern int glfwGetPlatform();

    [DllImport(libglfw3)]
    public static extern int glfwPlatformSupported(int platform);

    [DllImport(libglfw3)]
    public static extern GLFWmonitor** glfwGetMonitors(int* count);

    [DllImport(libglfw3)]
    public static extern GLFWmonitor* glfwGetPrimaryMonitor();

    [DllImport(libglfw3)]
    public static extern void glfwGetMonitorPos(GLFWmonitor* monitor, int* xpos, int* ypos);

    [DllImport(libglfw3)]
    public static extern void glfwGetMonitorWorkarea(GLFWmonitor* monitor, int* xpos, int* ypos, int* width, int* height);

    [DllImport(libglfw3)]
    public static extern void glfwGetMonitorPhysicalSize(GLFWmonitor* monitor, int* widthMM, int* heightMM);

    [DllImport(libglfw3)]
    public static extern void glfwGetMonitorContentScale(GLFWmonitor* monitor, float* xscale, float* yscale);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetMonitorName(GLFWmonitor* monitor);

    [DllImport(libglfw3)]
    public static extern void glfwSetMonitorUserPointer(GLFWmonitor* monitor, void* pointer);

    [DllImport(libglfw3)]
    public static extern void* glfwGetMonitorUserPointer(GLFWmonitor* monitor);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWmonitorfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWmonitor*, int, void> glfwSetMonitorCallback([NativeTypeName("GLFWmonitorfun")] delegate* unmanaged[Cdecl]<GLFWmonitor*, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const GLFWvidmode *")]
    public static extern GLFWvidmode* glfwGetVideoModes(GLFWmonitor* monitor, int* count);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const GLFWvidmode *")]
    public static extern GLFWvidmode* glfwGetVideoMode(GLFWmonitor* monitor);

    [DllImport(libglfw3)]
    public static extern void glfwSetGamma(GLFWmonitor* monitor, float gamma);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const GLFWgammaramp *")]
    public static extern GLFWgammaramp* glfwGetGammaRamp(GLFWmonitor* monitor);

    [DllImport(libglfw3)]
    public static extern void glfwSetGammaRamp(GLFWmonitor* monitor, [NativeTypeName("const GLFWgammaramp *")] GLFWgammaramp* ramp);

    [DllImport(libglfw3)]
    public static extern void glfwDefaultWindowHints();

    [DllImport(libglfw3)]
    public static extern void glfwWindowHint(int hint, int value);

    [DllImport(libglfw3)]
    public static extern void glfwWindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value);

    [DllImport(libglfw3)]
    public static extern GLFWwindow* glfwCreateWindow(int width, int height, [NativeTypeName("const char *")] sbyte* title, GLFWmonitor* monitor, GLFWwindow* share);

    [DllImport(libglfw3)]
    public static extern void glfwDestroyWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern int glfwWindowShouldClose(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowShouldClose(GLFWwindow* window, int value);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowTitle(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* title);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowIcon(GLFWwindow* window, int count, [NativeTypeName("const GLFWimage *")] GLFWimage* images);

    [DllImport(libglfw3)]
    public static extern void glfwGetWindowPos(GLFWwindow* window, int* xpos, int* ypos);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowPos(GLFWwindow* window, int xpos, int ypos);

    [DllImport(libglfw3)]
    public static extern void glfwGetWindowSize(GLFWwindow* window, int* width, int* height);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowSizeLimits(GLFWwindow* window, int minwidth, int minheight, int maxwidth, int maxheight);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowAspectRatio(GLFWwindow* window, int numer, int denom);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowSize(GLFWwindow* window, int width, int height);

    [DllImport(libglfw3)]
    public static extern void glfwGetFramebufferSize(GLFWwindow* window, int* width, int* height);

    [DllImport(libglfw3)]
    public static extern void glfwGetWindowFrameSize(GLFWwindow* window, int* left, int* top, int* right, int* bottom);

    [DllImport(libglfw3)]
    public static extern void glfwGetWindowContentScale(GLFWwindow* window, float* xscale, float* yscale);

    [DllImport(libglfw3)]
    public static extern float glfwGetWindowOpacity(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowOpacity(GLFWwindow* window, float opacity);

    [DllImport(libglfw3)]
    public static extern void glfwIconifyWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwRestoreWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwMaximizeWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwShowWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwHideWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwFocusWindow(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwRequestWindowAttention(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern GLFWmonitor* glfwGetWindowMonitor(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowMonitor(GLFWwindow* window, GLFWmonitor* monitor, int xpos, int ypos, int width, int height, int refreshRate);

    [DllImport(libglfw3)]
    public static extern int glfwGetWindowAttrib(GLFWwindow* window, int attrib);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowAttrib(GLFWwindow* window, int attrib, int value);

    [DllImport(libglfw3)]
    public static extern void glfwSetWindowUserPointer(GLFWwindow* window, void* pointer);

    [DllImport(libglfw3)]
    public static extern void* glfwGetWindowUserPointer(GLFWwindow* window);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowposfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> glfwSetWindowPosCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowsizefun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> glfwSetWindowSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowclosefun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, void> glfwSetWindowCloseCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged[Cdecl]<GLFWwindow*, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowrefreshfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, void> glfwSetWindowRefreshCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowfocusfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> glfwSetWindowFocusCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowiconifyfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> glfwSetWindowIconifyCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowmaximizefun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> glfwSetWindowMaximizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWframebuffersizefun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> glfwSetFramebufferSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWframebuffersizefun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, float, float, void> glfwSetWindowContentScaleCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowcontentscalefun")] delegate* unmanaged[Cdecl]<GLFWwindow*, float, float, void> callback);

    [DllImport(libglfw3)]
    public static extern void glfwPollEvents();

    [DllImport(libglfw3)]
    public static extern void glfwWaitEvents();

    [DllImport(libglfw3)]
    public static extern void glfwWaitEventsTimeout(double timeout);

    [DllImport(libglfw3)]
    public static extern void glfwPostEmptyEvent();

    [DllImport(libglfw3)]
    public static extern int glfwGetInputMode(GLFWwindow* window, int mode);

    [DllImport(libglfw3)]
    public static extern void glfwSetInputMode(GLFWwindow* window, int mode, int value);

    [DllImport(libglfw3)]
    public static extern int glfwRawMouseMotionSupported();

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetKeyName(int key, int scancode);

    [DllImport(libglfw3)]
    public static extern int glfwGetKeyScancode(int key);

    [DllImport(libglfw3)]
    public static extern int glfwGetKey(GLFWwindow* window, int key);

    [DllImport(libglfw3)]
    public static extern int glfwGetMouseButton(GLFWwindow* window, int button);

    [DllImport(libglfw3)]
    public static extern void glfwGetCursorPos(GLFWwindow* window, double* xpos, double* ypos);

    [DllImport(libglfw3)]
    public static extern void glfwSetCursorPos(GLFWwindow* window, double xpos, double ypos);

    [DllImport(libglfw3)]
    public static extern GLFWcursor* glfwCreateCursor([NativeTypeName("const GLFWimage *")] GLFWimage* image, int xhot, int yhot);

    [DllImport(libglfw3)]
    public static extern GLFWcursor* glfwCreateStandardCursor(int shape);

    [DllImport(libglfw3)]
    public static extern void glfwDestroyCursor(GLFWcursor* cursor);

    [DllImport(libglfw3)]
    public static extern void glfwSetCursor(GLFWwindow* window, GLFWcursor* cursor);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWkeyfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, int, void> glfwSetKeyCallback(GLFWwindow* window, [NativeTypeName("GLFWkeyfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWcharfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, uint, void> glfwSetCharCallback(GLFWwindow* window, [NativeTypeName("GLFWcharfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, uint, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWcharmodsfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, uint, int, void> glfwSetCharModsCallback(GLFWwindow* window, [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, uint, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWmousebuttonfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, void> glfwSetMouseButtonCallback(GLFWwindow* window, [NativeTypeName("GLFWmousebuttonfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWcursorposfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, double, double, void> glfwSetCursorPosCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorposfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, double, double, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWcursorenterfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> glfwSetCursorEnterCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWscrollfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, double, double, void> glfwSetScrollCallback(GLFWwindow* window, [NativeTypeName("GLFWscrollfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, double, double, void> callback);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWdropfun")]
    public static extern delegate* unmanaged[Cdecl]<GLFWwindow*, int, sbyte**, void> glfwSetDropCallback(GLFWwindow* window, [NativeTypeName("GLFWdropfun")] delegate* unmanaged[Cdecl]<GLFWwindow*, int, sbyte**, void> callback);

    [DllImport(libglfw3)]
    public static extern int glfwJoystickPresent(int jid);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const float *")]
    public static extern float* glfwGetJoystickAxes(int jid, int* count);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const unsigned char *")]
    public static extern byte* glfwGetJoystickButtons(int jid, int* count);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const unsigned char *")]
    public static extern byte* glfwGetJoystickHats(int jid, int* count);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetJoystickName(int jid);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetJoystickGUID(int jid);

    [DllImport(libglfw3)]
    public static extern void glfwSetJoystickUserPointer(int jid, void* pointer);

    [DllImport(libglfw3)]
    public static extern void* glfwGetJoystickUserPointer(int jid);

    [DllImport(libglfw3)]
    public static extern int glfwJoystickIsGamepad(int jid);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWjoystickfun")]
    public static extern delegate* unmanaged[Cdecl]<int, int, void> glfwSetJoystickCallback([NativeTypeName("GLFWjoystickfun")] delegate* unmanaged[Cdecl]<int, int, void> callback);

    [DllImport(libglfw3)]
    public static extern int glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetGamepadName(int jid);

    [DllImport(libglfw3)]
    public static extern int glfwGetGamepadState(int jid, GLFWgamepadstate* state);

    [DllImport(libglfw3)]
    public static extern void glfwSetClipboardString(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* @string);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetClipboardString(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern double glfwGetTime();

    [DllImport(libglfw3)]
    public static extern void glfwSetTime(double time);

    [DllImport(libglfw3)]
    [return: NativeTypeName("uint64_t")]
    public static extern nuint glfwGetTimerValue();

    [DllImport(libglfw3)]
    [return: NativeTypeName("uint64_t")]
    public static extern nuint glfwGetTimerFrequency();

    [DllImport(libglfw3)]
    public static extern void glfwMakeContextCurrent(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern GLFWwindow* glfwGetCurrentContext();

    [DllImport(libglfw3)]
    public static extern void glfwSwapBuffers(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwSwapInterval(int interval);

    [DllImport(libglfw3)]
    public static extern int glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

    [DllImport(libglfw3)]
    [return: NativeTypeName("GLFWglproc")]
    public static extern delegate* unmanaged[Cdecl]<void> glfwGetProcAddress([NativeTypeName("const char *")] sbyte* procname);

    [DllImport(libglfw3)]
    public static extern int glfwVulkanSupported();

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char **")]
    public static extern sbyte** glfwGetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count);

    [DllImport(libglfw3)]
    [return: NativeTypeName("Display*")]
    public static extern void *glfwGetX11Display();

    [DllImport(libglfw3)]
    [return: NativeTypeName("Window")]
    public static extern void *glfwGetX11Window(GLFWwindow* window);

    [DllImport(libglfw3)]
    public static extern void glfwSetX11SelectionString([NativeTypeName("const char *")] sbyte *@string);

    [DllImport(libglfw3)]
    [return: NativeTypeName("const char **")]
    public static extern sbyte* glfwGetX11SelectionString();


    // Defines
    public const int GLFW_TRUE  = 1,
                    GLFW_FALSE = 0;

    public const int GLFW_RELEASE = 0,
                    GLFW_PRESS    = 1,
                    GLFW_REPEAT   = 2;

    public const int GLFW_HAT_CENTERED      = 0,
                     GLFW_HAT_UP            = 1,
                     GLFW_HAT_RIGHT         = 2,
                     GLFW_HAT_DOWN          = 4,
                     GLFW_HAT_LEFT          = 8,
                     GLFW_HAT_RIGHT_UP      = (GLFW_HAT_RIGHT | GLFW_HAT_UP),
                     GLFW_HAT_RIGHT_DOWN    = (GLFW_HAT_RIGHT | GLFW_HAT_DOWN),
                     GLFW_HAT_LEFT_UP       = (GLFW_HAT_LEFT  | GLFW_HAT_UP),
                     GLFW_HAT_LEFT_DOWN     = (GLFW_HAT_LEFT  | GLFW_HAT_DOWN);

    public const int GLFW_KEY_UNKNOWN =       -1,
                    GLFW_KEY_SPACE       =       32,
                    GLFW_KEY_APOSTROPHE  =       39,  /* ' */
                    GLFW_KEY_COMMA       =       44,  /* , */
                    GLFW_KEY_MINUS       =       45,  /* - */
                    GLFW_KEY_PERIOD      =       46,  /* . */
                    GLFW_KEY_SLASH       =       47,  /* / */
                    GLFW_KEY_0           =       48,
                    GLFW_KEY_1           =       49,
                    GLFW_KEY_2           =       50,
                    GLFW_KEY_3           =       51,
                    GLFW_KEY_4           =       52,
                    GLFW_KEY_5           =       53,
                    GLFW_KEY_6           =       54,
                    GLFW_KEY_7           =       55,
                    GLFW_KEY_8           =       56,
                    GLFW_KEY_9           =       57,
                    GLFW_KEY_SEMICOLON   =       59, /* ; */
                    GLFW_KEY_EQUAL       =       61,  /* = */
                    GLFW_KEY_A           =       65,
                    GLFW_KEY_B           =       66,
                    GLFW_KEY_C           =       67,
                    GLFW_KEY_D           =       68,
                    GLFW_KEY_E           =       69,
                    GLFW_KEY_F           =       70,
                    GLFW_KEY_G           =       71,
                    GLFW_KEY_H           =       72,
                    GLFW_KEY_I           =       73,
                    GLFW_KEY_J           =       74,
                    GLFW_KEY_K           =       75,
                    GLFW_KEY_L           =       76,
                    GLFW_KEY_M           =       77,
                    GLFW_KEY_N           =       78,
                    GLFW_KEY_O           =       79,
                    GLFW_KEY_P           =       80,
                    GLFW_KEY_Q           =       81,
                    GLFW_KEY_R           =       82,
                    GLFW_KEY_S           =       83,
                    GLFW_KEY_T           =       84,
                    GLFW_KEY_U           =       85,
                    GLFW_KEY_V           =       86,
                    GLFW_KEY_W           =       87,
                    GLFW_KEY_X           =       88,
                    GLFW_KEY_Y           =       89,
                    GLFW_KEY_Z           =       90,
                    GLFW_KEY_LEFT_BRACKET=       91,  /* [ */
                    GLFW_KEY_BACKSLASH   =       92,  /* \ */
                    GLFW_KEY_RIGHT_BRACKET =      93,  /* ] */
                    GLFW_KEY_GRAVE_ACCENT=       96,  /* ` */
                    GLFW_KEY_WORLD_1     =       161, /* non-US #1 */
                    GLFW_KEY_WORLD_2     =       162, /* non-US #2 */
                    GLFW_KEY_ESCAPE      =       256,
                    GLFW_KEY_ENTER       =       257,
                    GLFW_KEY_TAB         =       258,
                    GLFW_KEY_BACKSPACE   =      259,
                    GLFW_KEY_INSERT      =      260,
                    GLFW_KEY_DELETE      =      261,
                    GLFW_KEY_RIGHT         =     262,
                    GLFW_KEY_LEFT          =     263,
                    GLFW_KEY_DOWN          =     264,
                    GLFW_KEY_UP            =     265,
                    GLFW_KEY_PAGE_UP       =     266,
                    GLFW_KEY_PAGE_DOWN     =     267,
                    GLFW_KEY_HOME          =     268,
                    GLFW_KEY_END           =     269,
                    GLFW_KEY_CAPS_LOCK     =     280,
                    GLFW_KEY_SCROLL_LOCK   =     281,
                    GLFW_KEY_NUM_LOCK      =     282,
                    GLFW_KEY_PRINT_SCREEN  =     283,
                    GLFW_KEY_PAUSE         =     284,
                    GLFW_KEY_F1            =     290,
                    GLFW_KEY_F2            =     291,
                    GLFW_KEY_F3            =     292,
                    GLFW_KEY_F4            =     293,
                    GLFW_KEY_F5            =     294,
                    GLFW_KEY_F6            =     295,
                    GLFW_KEY_F7            =     296,
                    GLFW_KEY_F8            =     297,
                    GLFW_KEY_F9            =     298,
                    GLFW_KEY_F10           =     299,
                    GLFW_KEY_F11           =     300,
                    GLFW_KEY_F12           =     301,
                    GLFW_KEY_F13           =     302,
                    GLFW_KEY_F14           =     303,
                    GLFW_KEY_F15           =     304,
                    GLFW_KEY_F16           =     305,
                    GLFW_KEY_F17           =     306,
                    GLFW_KEY_F18           =     307,
                    GLFW_KEY_F19           =     308,
                    GLFW_KEY_F20           =     309,
                    GLFW_KEY_F21           =     310,
                    GLFW_KEY_F22           =     311,
                    GLFW_KEY_F23           =     312,
                    GLFW_KEY_F24           =     313,
                    GLFW_KEY_F25           =     314,
                    GLFW_KEY_KP_0          =     320,
                    GLFW_KEY_KP_1          =     321,
                    GLFW_KEY_KP_2          =     322,
                    GLFW_KEY_KP_3          =     323,
                    GLFW_KEY_KP_4          =     324,
                    GLFW_KEY_KP_5          =     325,
                    GLFW_KEY_KP_6          =     326,
                    GLFW_KEY_KP_7          =     327,
                    GLFW_KEY_KP_8          =     328,
                    GLFW_KEY_KP_9          =     329,
                    GLFW_KEY_KP_DECIMAL    =     330,
                    GLFW_KEY_KP_DIVIDE     =     331,
                    GLFW_KEY_KP_MULTIPLY   =     332,
                    GLFW_KEY_KP_SUBTRACT   =     333,
                    GLFW_KEY_KP_ADD        =     334,
                    GLFW_KEY_KP_ENTER      =     335,
                    GLFW_KEY_KP_EQUAL      =     336,
                    GLFW_KEY_LEFT_SHIFT    =     340,
                    GLFW_KEY_LEFT_CONTROL  =     341,
                    GLFW_KEY_LEFT_ALT      =     342,
                    GLFW_KEY_LEFT_SUPER    =     343,
                    GLFW_KEY_RIGHT_SHIFT   =     344,
                    GLFW_KEY_RIGHT_CONTROL =     345,
                    GLFW_KEY_RIGHT_ALT     =     346,
                    GLFW_KEY_RIGHT_SUPER   =     347,
                    GLFW_KEY_MENU          =     348,
                    GLFW_KEY_LAST          =     GLFW_KEY_MENU,
                    GLFW_MOD_SHIFT         =  0x0001,
                    GLFW_MOD_CONTROL       =  0x0002,
                    GLFW_MOD_ALT           =  0x0004,
                    GLFW_MOD_SUPER         =  0x0008,
                    GLFW_MOD_CAPS_LOCK     =  0x0010,
                    GLFW_MOD_NUM_LOCK      =  0x0020;

    public const int GLFW_MOUSE_BUTTON_1  =       0,
                    GLFW_MOUSE_BUTTON_2      =   1,
                    GLFW_MOUSE_BUTTON_3      =   2,
                    GLFW_MOUSE_BUTTON_4      =   3,
                    GLFW_MOUSE_BUTTON_5      =   4,
                    GLFW_MOUSE_BUTTON_6      =   5,
                    GLFW_MOUSE_BUTTON_7      =   6,
                    GLFW_MOUSE_BUTTON_8      =   7,
                    GLFW_MOUSE_BUTTON_LAST   =   GLFW_MOUSE_BUTTON_8,
                    GLFW_MOUSE_BUTTON_LEFT   =   GLFW_MOUSE_BUTTON_1,
                    GLFW_MOUSE_BUTTON_RIGHT  =   GLFW_MOUSE_BUTTON_2,
                    GLFW_MOUSE_BUTTON_MIDDLE =   GLFW_MOUSE_BUTTON_3;

    public const int GLFW_JOYSTICK_1       =      0,
                    GLFW_JOYSTICK_2        =     1,
                    GLFW_JOYSTICK_3        =     2,
                    GLFW_JOYSTICK_4        =     3,
                    GLFW_JOYSTICK_5        =     4,
                    GLFW_JOYSTICK_6        =     5,
                    GLFW_JOYSTICK_7        =     6,
                    GLFW_JOYSTICK_8        =     7,
                    GLFW_JOYSTICK_9        =     8,
                    GLFW_JOYSTICK_10       =     9,
                    GLFW_JOYSTICK_11       =     10,
                    GLFW_JOYSTICK_12       =     11,
                    GLFW_JOYSTICK_13       =     12,
                    GLFW_JOYSTICK_14       =     13,
                    GLFW_JOYSTICK_15       =     14,
                    GLFW_JOYSTICK_16       =     15,
                    GLFW_JOYSTICK_LAST     =     GLFW_JOYSTICK_16;

    public const int GLFW_GAMEPAD_BUTTON_A             =  0,
                    GLFW_GAMEPAD_BUTTON_B              = 1,
                    GLFW_GAMEPAD_BUTTON_X              = 2,
                    GLFW_GAMEPAD_BUTTON_Y              = 3,
                    GLFW_GAMEPAD_BUTTON_LEFT_BUMPER    = 4,
                    GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER   = 5,
                    GLFW_GAMEPAD_BUTTON_BACK           = 6,
                    GLFW_GAMEPAD_BUTTON_START          = 7,
                    GLFW_GAMEPAD_BUTTON_GUIDE          = 8,
                    GLFW_GAMEPAD_BUTTON_LEFT_THUMB     = 9,
                    GLFW_GAMEPAD_BUTTON_RIGHT_THUMB    = 10,
                    GLFW_GAMEPAD_BUTTON_DPAD_UP        = 11,
                    GLFW_GAMEPAD_BUTTON_DPAD_RIGHT     = 12,
                    GLFW_GAMEPAD_BUTTON_DPAD_DOWN      = 13,
                    GLFW_GAMEPAD_BUTTON_DPAD_LEFT      = 14,
                    GLFW_GAMEPAD_BUTTON_LAST           = GLFW_GAMEPAD_BUTTON_DPAD_LEFT,
                    GLFW_GAMEPAD_BUTTON_CROSS          = GLFW_GAMEPAD_BUTTON_A,
                    GLFW_GAMEPAD_BUTTON_CIRCLE         = GLFW_GAMEPAD_BUTTON_B,
                    GLFW_GAMEPAD_BUTTON_SQUARE         = GLFW_GAMEPAD_BUTTON_X,
                    GLFW_GAMEPAD_BUTTON_TRIANGLE       = GLFW_GAMEPAD_BUTTON_Y,
                    GLFW_GAMEPAD_AXIS_LEFT_X           = 0,
                    GLFW_GAMEPAD_AXIS_LEFT_Y           = 1,
                    GLFW_GAMEPAD_AXIS_RIGHT_X          = 2,
                    GLFW_GAMEPAD_AXIS_RIGHT_Y          = 3,
                    GLFW_GAMEPAD_AXIS_LEFT_TRIGGER     = 4,
                    GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER    = 5,
                    GLFW_GAMEPAD_AXIS_LAST             = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
    public const uint GLFW_NO_ERROR              =          0,
                      GLFW_NOT_INITIALIZED       = 0x00010001,
                      GLFW_NO_CURRENT_CONTEXT    = 0x00010002,
                      GLFW_INVALID_ENUM          = 0x00010003,
                      GLFW_INVALID_VALUE         = 0x00010004,
                      GLFW_OUT_OF_MEMORY         = 0x00010005,
                      GLFW_API_UNAVAILABLE       = 0x00010006,
                      GLFW_VERSION_UNAVAILABLE   = 0x00010007,
                      GLFW_PLATFORM_ERROR        = 0x00010008,
                      GLFW_FORMAT_UNAVAILABLE    = 0x00010009,
                      GLFW_NO_WINDOW_CONTEXT     = 0x0001000A,
                      GLFW_CURSOR_UNAVAILABLE    = 0x0001000B,
                      GLFW_FEATURE_UNAVAILABLE   = 0x0001000C,
                      GLFW_FEATURE_UNIMPLEMENTED = 0x0001000D,
                      GLFW_PLATFORM_UNAVAILABLE  = 0x0001000E,
                      GLFW_FOCUSED               = 0x00020001,
                      GLFW_ICONIFIED             = 0x00020002,
                      GLFW_RESIZABLE             = 0x00020003,
                      GLFW_VISIBLE               = 0x00020004,
                      GLFW_DECORATED             = 0x00020005,
                      GLFW_AUTO_ICONIFY          = 0x00020006,
                      GLFW_FLOATING              = 0x00020007,
                      GLFW_MAXIMIZED             = 0x00020008,
                      GLFW_CENTER_CURSOR         = 0x00020009,
                    GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A,
                      GLFW_HOVERED               = 0x0002000B,
                      GLFW_FOCUS_ON_SHOW         = 0x0002000C,
                      GLFW_MOUSE_PASSTHROUGH     = 0x0002000D,
                      GLFW_POSITION_X            = 0x0002000E,
                      GLFW_POSITION_Y            = 0x0002000F,
                      GLFW_RED_BITS              = 0x00021001,
                      GLFW_GREEN_BITS            = 0x00021002,
                      GLFW_BLUE_BITS             = 0x00021003,
                      GLFW_ALPHA_BITS            = 0x00021004,
                      GLFW_DEPTH_BITS            = 0x00021005,
                      GLFW_STENCIL_BITS          = 0x00021006,
                      GLFW_ACCUM_RED_BITS        = 0x00021007,
                      GLFW_ACCUM_GREEN_BITS      = 0x00021008,
                      GLFW_ACCUM_BLUE_BITS       = 0x00021009,
                      GLFW_ACCUM_ALPHA_BITS      = 0x0002100A,
                      GLFW_AUX_BUFFERS           = 0x0002100B,
                      GLFW_STEREO                = 0x0002100C,
                      GLFW_SAMPLES               = 0x0002100D,
                      GLFW_SRGB_CAPABLE          = 0x0002100E,
                      GLFW_REFRESH_RATE          = 0x0002100F,
                      GLFW_DOUBLEBUFFER          = 0x00021010,
                      GLFW_CLIENT_API            = 0x00022001,
                      GLFW_CONTEXT_VERSION_MAJOR = 0x00022002,
                      GLFW_CONTEXT_VERSION_MINOR = 0x00022003,
                      GLFW_CONTEXT_REVISION      = 0x00022004,
                      GLFW_CONTEXT_ROBUSTNESS    = 0x00022005,
                      GLFW_OPENGL_FORWARD_COMPAT = 0x00022006,
                      GLFW_CONTEXT_DEBUG         = 0x00022007,
                      GLFW_OPENGL_PROFILE        = 0x00022008,
                    GLFW_CONTEXT_RELEASE_BEHAVIOR= 0x00022009,
                      GLFW_CONTEXT_NO_ERROR      = 0x0002200A,
                      GLFW_CONTEXT_CREATION_API  = 0x0002200B,
                      GLFW_SCALE_TO_MONITOR      = 0x0002200C,
                    GLFW_COCOA_RETINA_FRAMEBUFFER= 0x00023001,
                      GLFW_COCOA_FRAME_NAME      = 0x00023002,
                    GLFW_COCOA_GRAPHICS_SWITCHING= 0x00023003,
                      GLFW_X11_CLASS_NAME        = 0x00024001,
                      GLFW_X11_INSTANCE_NAME     = 0x00024002,
                      GLFW_WIN32_KEYBOARD_MENU   = 0x00025001,
                      GLFW_WAYLAND_APP_ID        = 0x00026001,
                      GLFW_NO_API                =          0,
                      GLFW_OPENGL_API            = 0x00030001,
                      GLFW_OPENGL_ES_API         = 0x00030002,
                      GLFW_NO_ROBUSTNESS         =          0,
                      GLFW_NO_RESET_NOTIFICATION = 0x00031001,
                      GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002,
                      GLFW_OPENGL_ANY_PROFILE    =          0,
                      GLFW_OPENGL_CORE_PROFILE   = 0x00032001,
                      GLFW_OPENGL_COMPAT_PROFILE = 0x00032002,
                      GLFW_CURSOR                = 0x00033001,
                      GLFW_STICKY_KEYS           = 0x00033002,
                      GLFW_STICKY_MOUSE_BUTTONS  = 0x00033003,
                      GLFW_LOCK_KEY_MODS         = 0x00033004,
                      GLFW_RAW_MOUSE_MOTION      = 0x00033005,
                      GLFW_CURSOR_NORMAL         = 0x00034001,
                      GLFW_CURSOR_HIDDEN         = 0x00034002,
                      GLFW_CURSOR_DISABLED       = 0x00034003,
                      GLFW_CURSOR_CAPTURED       = 0x00034004,
                      GLFW_ANY_RELEASE_BEHAVIOR  =          0,
                      GLFW_RELEASE_BEHAVIOR_FLUSH= 0x00035001,
                      GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002,
                      GLFW_NATIVE_CONTEXT_API    = 0x00036001,
                      GLFW_EGL_CONTEXT_API       = 0x00036002,
                      GLFW_OSMESA_CONTEXT_API    = 0x00036003,
                 GLFW_ANGLE_PLATFORM_TYPE_NONE   = 0x00037001,
                 GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x00037002,
                GLFW_ANGLE_PLATFORM_TYPE_OPENGLES= 0x00037003,
                 GLFW_ANGLE_PLATFORM_TYPE_D3D9   = 0x00037004,
                 GLFW_ANGLE_PLATFORM_TYPE_D3D11  = 0x00037005,
                 GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x00037007,
                 GLFW_ANGLE_PLATFORM_TYPE_METAL  = 0x00037008,
                  GLFW_WAYLAND_PREFER_LIBDECOR   = 0x00038001,
                  GLFW_WAYLAND_DISABLE_LIBDECOR  = 0x00038002,
                      GLFW_ANY_POSITION          = 0x80000000,
                      GLFW_ARROW_CURSOR          = 0x00036001,
                      GLFW_IBEAM_CURSOR          = 0x00036002,
                      GLFW_CROSSHAIR_CURSOR      = 0x00036003,
                      GLFW_POINTING_HAND_CURSOR  = 0x00036004,
                      GLFW_RESIZE_EW_CURSOR      = 0x00036005,
                      GLFW_RESIZE_NS_CURSOR      = 0x00036006,
                      GLFW_RESIZE_NWSE_CURSOR    = 0x00036007,
                      GLFW_RESIZE_NESW_CURSOR    = 0x00036008,
                      GLFW_RESIZE_ALL_CURSOR     = 0x00036009,
                      GLFW_NOT_ALLOWED_CURSOR    = 0x0003600A,
                      GLFW_HRESIZE_CURSOR        = GLFW_RESIZE_EW_CURSOR,
                      GLFW_VRESIZE_CURSOR        = GLFW_RESIZE_NS_CURSOR,
                      GLFW_HAND_CURSOR           = GLFW_POINTING_HAND_CURSOR,
                      GLFW_CONNECTED             = 0x00040001,
                      GLFW_DISCONNECTED          = 0x00040002,
                      GLFW_JOYSTICK_HAT_BUTTONS  = 0x00050001,
                      GLFW_ANGLE_PLATFORM_TYPE   = 0x00050002,
                      GLFW_PLATFORM              = 0x00050003,
                      GLFW_COCOA_CHDIR_RESOURCES = 0x00051001,
                      GLFW_COCOA_MENUBAR         = 0x00051002,
                      GLFW_X11_XCB_VULKAN_SURFACE= 0x00052001,
                      GLFW_WAYLAND_LIBDECOR      = 0x00053001,
                      GLFW_ANY_PLATFORM          = 0x00060000,
                      GLFW_PLATFORM_WIN32        = 0x00060001,
                      GLFW_PLATFORM_COCOA        = 0x00060002,
                      GLFW_PLATFORM_WAYLAND      = 0x00060003,
                      GLFW_PLATFORM_X11          = 0x00060004,
                      GLFW_PLATFORM_NULL         = 0x00060005;

    public const int GLFW_DONT_CARE = -1;

}