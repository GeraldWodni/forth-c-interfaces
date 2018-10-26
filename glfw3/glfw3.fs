\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

c-library glfw3
s" glfw" add-lib
\c #include<GLFW/glfw3.h>

\ ----===< int constants ===>-----
#3	constant GLFW_VERSION_MAJOR
#3	constant GLFW_VERSION_MINOR
#0	constant GLFW_VERSION_REVISION
#1	constant GLFW_TRUE
#0	constant GLFW_FALSE
#0	constant GLFW_RELEASE
#1	constant GLFW_PRESS
#2	constant GLFW_REPEAT
#0	constant GLFW_HAT_CENTERED
#1	constant GLFW_HAT_UP
#2	constant GLFW_HAT_RIGHT
#4	constant GLFW_HAT_DOWN
#8	constant GLFW_HAT_LEFT
#3	constant GLFW_HAT_RIGHT_UP
#6	constant GLFW_HAT_RIGHT_DOWN
#9	constant GLFW_HAT_LEFT_UP
#12	constant GLFW_HAT_LEFT_DOWN
#-1	constant GLFW_KEY_UNKNOWN
#32	constant GLFW_KEY_SPACE
#39	constant GLFW_KEY_APOSTROPHE
#44	constant GLFW_KEY_COMMA
#45	constant GLFW_KEY_MINUS
#46	constant GLFW_KEY_PERIOD
#47	constant GLFW_KEY_SLASH
#48	constant GLFW_KEY_0
#49	constant GLFW_KEY_1
#50	constant GLFW_KEY_2
#51	constant GLFW_KEY_3
#52	constant GLFW_KEY_4
#53	constant GLFW_KEY_5
#54	constant GLFW_KEY_6
#55	constant GLFW_KEY_7
#56	constant GLFW_KEY_8
#57	constant GLFW_KEY_9
#59	constant GLFW_KEY_SEMICOLON
#61	constant GLFW_KEY_EQUAL
#65	constant GLFW_KEY_A
#66	constant GLFW_KEY_B
#67	constant GLFW_KEY_C
#68	constant GLFW_KEY_D
#69	constant GLFW_KEY_E
#70	constant GLFW_KEY_F
#71	constant GLFW_KEY_G
#72	constant GLFW_KEY_H
#73	constant GLFW_KEY_I
#74	constant GLFW_KEY_J
#75	constant GLFW_KEY_K
#76	constant GLFW_KEY_L
#77	constant GLFW_KEY_M
#78	constant GLFW_KEY_N
#79	constant GLFW_KEY_O
#80	constant GLFW_KEY_P
#81	constant GLFW_KEY_Q
#82	constant GLFW_KEY_R
#83	constant GLFW_KEY_S
#84	constant GLFW_KEY_T
#85	constant GLFW_KEY_U
#86	constant GLFW_KEY_V
#87	constant GLFW_KEY_W
#88	constant GLFW_KEY_X
#89	constant GLFW_KEY_Y
#90	constant GLFW_KEY_Z
#91	constant GLFW_KEY_LEFT_BRACKET
#92	constant GLFW_KEY_BACKSLASH
#93	constant GLFW_KEY_RIGHT_BRACKET
#96	constant GLFW_KEY_GRAVE_ACCENT
#161	constant GLFW_KEY_WORLD_1
#162	constant GLFW_KEY_WORLD_2
#256	constant GLFW_KEY_ESCAPE
#257	constant GLFW_KEY_ENTER
#258	constant GLFW_KEY_TAB
#259	constant GLFW_KEY_BACKSPACE
#260	constant GLFW_KEY_INSERT
#261	constant GLFW_KEY_DELETE
#262	constant GLFW_KEY_RIGHT
#263	constant GLFW_KEY_LEFT
#264	constant GLFW_KEY_DOWN
#265	constant GLFW_KEY_UP
#266	constant GLFW_KEY_PAGE_UP
#267	constant GLFW_KEY_PAGE_DOWN
#268	constant GLFW_KEY_HOME
#269	constant GLFW_KEY_END
#280	constant GLFW_KEY_CAPS_LOCK
#281	constant GLFW_KEY_SCROLL_LOCK
#282	constant GLFW_KEY_NUM_LOCK
#283	constant GLFW_KEY_PRINT_SCREEN
#284	constant GLFW_KEY_PAUSE
#290	constant GLFW_KEY_F1
#291	constant GLFW_KEY_F2
#292	constant GLFW_KEY_F3
#293	constant GLFW_KEY_F4
#294	constant GLFW_KEY_F5
#295	constant GLFW_KEY_F6
#296	constant GLFW_KEY_F7
#297	constant GLFW_KEY_F8
#298	constant GLFW_KEY_F9
#299	constant GLFW_KEY_F10
#300	constant GLFW_KEY_F11
#301	constant GLFW_KEY_F12
#302	constant GLFW_KEY_F13
#303	constant GLFW_KEY_F14
#304	constant GLFW_KEY_F15
#305	constant GLFW_KEY_F16
#306	constant GLFW_KEY_F17
#307	constant GLFW_KEY_F18
#308	constant GLFW_KEY_F19
#309	constant GLFW_KEY_F20
#310	constant GLFW_KEY_F21
#311	constant GLFW_KEY_F22
#312	constant GLFW_KEY_F23
#313	constant GLFW_KEY_F24
#314	constant GLFW_KEY_F25
#320	constant GLFW_KEY_KP_0
#321	constant GLFW_KEY_KP_1
#322	constant GLFW_KEY_KP_2
#323	constant GLFW_KEY_KP_3
#324	constant GLFW_KEY_KP_4
#325	constant GLFW_KEY_KP_5
#326	constant GLFW_KEY_KP_6
#327	constant GLFW_KEY_KP_7
#328	constant GLFW_KEY_KP_8
#329	constant GLFW_KEY_KP_9
#330	constant GLFW_KEY_KP_DECIMAL
#331	constant GLFW_KEY_KP_DIVIDE
#332	constant GLFW_KEY_KP_MULTIPLY
#333	constant GLFW_KEY_KP_SUBTRACT
#334	constant GLFW_KEY_KP_ADD
#335	constant GLFW_KEY_KP_ENTER
#336	constant GLFW_KEY_KP_EQUAL
#340	constant GLFW_KEY_LEFT_SHIFT
#341	constant GLFW_KEY_LEFT_CONTROL
#342	constant GLFW_KEY_LEFT_ALT
#343	constant GLFW_KEY_LEFT_SUPER
#344	constant GLFW_KEY_RIGHT_SHIFT
#345	constant GLFW_KEY_RIGHT_CONTROL
#346	constant GLFW_KEY_RIGHT_ALT
#347	constant GLFW_KEY_RIGHT_SUPER
#348	constant GLFW_KEY_MENU
#348	constant GLFW_KEY_LAST
#1	constant GLFW_MOD_SHIFT
#2	constant GLFW_MOD_CONTROL
#4	constant GLFW_MOD_ALT
#8	constant GLFW_MOD_SUPER
#16	constant GLFW_MOD_CAPS_LOCK
#32	constant GLFW_MOD_NUM_LOCK
#0	constant GLFW_MOUSE_BUTTON_1
#1	constant GLFW_MOUSE_BUTTON_2
#2	constant GLFW_MOUSE_BUTTON_3
#3	constant GLFW_MOUSE_BUTTON_4
#4	constant GLFW_MOUSE_BUTTON_5
#5	constant GLFW_MOUSE_BUTTON_6
#6	constant GLFW_MOUSE_BUTTON_7
#7	constant GLFW_MOUSE_BUTTON_8
#7	constant GLFW_MOUSE_BUTTON_LAST
#0	constant GLFW_MOUSE_BUTTON_LEFT
#1	constant GLFW_MOUSE_BUTTON_RIGHT
#2	constant GLFW_MOUSE_BUTTON_MIDDLE
#0	constant GLFW_JOYSTICK_1
#1	constant GLFW_JOYSTICK_2
#2	constant GLFW_JOYSTICK_3
#3	constant GLFW_JOYSTICK_4
#4	constant GLFW_JOYSTICK_5
#5	constant GLFW_JOYSTICK_6
#6	constant GLFW_JOYSTICK_7
#7	constant GLFW_JOYSTICK_8
#8	constant GLFW_JOYSTICK_9
#9	constant GLFW_JOYSTICK_10
#10	constant GLFW_JOYSTICK_11
#11	constant GLFW_JOYSTICK_12
#12	constant GLFW_JOYSTICK_13
#13	constant GLFW_JOYSTICK_14
#14	constant GLFW_JOYSTICK_15
#15	constant GLFW_JOYSTICK_16
#15	constant GLFW_JOYSTICK_LAST
#0	constant GLFW_GAMEPAD_BUTTON_A
#1	constant GLFW_GAMEPAD_BUTTON_B
#2	constant GLFW_GAMEPAD_BUTTON_X
#3	constant GLFW_GAMEPAD_BUTTON_Y
#4	constant GLFW_GAMEPAD_BUTTON_LEFT_BUMPER
#5	constant GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER
#6	constant GLFW_GAMEPAD_BUTTON_BACK
#7	constant GLFW_GAMEPAD_BUTTON_START
#8	constant GLFW_GAMEPAD_BUTTON_GUIDE
#9	constant GLFW_GAMEPAD_BUTTON_LEFT_THUMB
#10	constant GLFW_GAMEPAD_BUTTON_RIGHT_THUMB
#11	constant GLFW_GAMEPAD_BUTTON_DPAD_UP
#12	constant GLFW_GAMEPAD_BUTTON_DPAD_RIGHT
#13	constant GLFW_GAMEPAD_BUTTON_DPAD_DOWN
#14	constant GLFW_GAMEPAD_BUTTON_DPAD_LEFT
#14	constant GLFW_GAMEPAD_BUTTON_LAST
#0	constant GLFW_GAMEPAD_BUTTON_CROSS
#1	constant GLFW_GAMEPAD_BUTTON_CIRCLE
#2	constant GLFW_GAMEPAD_BUTTON_SQUARE
#3	constant GLFW_GAMEPAD_BUTTON_TRIANGLE
#0	constant GLFW_GAMEPAD_AXIS_LEFT_X
#1	constant GLFW_GAMEPAD_AXIS_LEFT_Y
#2	constant GLFW_GAMEPAD_AXIS_RIGHT_X
#3	constant GLFW_GAMEPAD_AXIS_RIGHT_Y
#4	constant GLFW_GAMEPAD_AXIS_LEFT_TRIGGER
#5	constant GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER
#5	constant GLFW_GAMEPAD_AXIS_LAST
#0	constant GLFW_NO_ERROR
#65537	constant GLFW_NOT_INITIALIZED
#65538	constant GLFW_NO_CURRENT_CONTEXT
#65539	constant GLFW_INVALID_ENUM
#65540	constant GLFW_INVALID_VALUE
#65541	constant GLFW_OUT_OF_MEMORY
#65542	constant GLFW_API_UNAVAILABLE
#65543	constant GLFW_VERSION_UNAVAILABLE
#65544	constant GLFW_PLATFORM_ERROR
#65545	constant GLFW_FORMAT_UNAVAILABLE
#65546	constant GLFW_NO_WINDOW_CONTEXT
#131073	constant GLFW_FOCUSED
#131074	constant GLFW_ICONIFIED
#131075	constant GLFW_RESIZABLE
#131076	constant GLFW_VISIBLE
#131077	constant GLFW_DECORATED
#131078	constant GLFW_AUTO_ICONIFY
#131079	constant GLFW_FLOATING
#131080	constant GLFW_MAXIMIZED
#131081	constant GLFW_CENTER_CURSOR
#131082	constant GLFW_TRANSPARENT_FRAMEBUFFER
#131083	constant GLFW_HOVERED
#131084	constant GLFW_FOCUS_ON_SHOW
#135169	constant GLFW_RED_BITS
#135170	constant GLFW_GREEN_BITS
#135171	constant GLFW_BLUE_BITS
#135172	constant GLFW_ALPHA_BITS
#135173	constant GLFW_DEPTH_BITS
#135174	constant GLFW_STENCIL_BITS
#135175	constant GLFW_ACCUM_RED_BITS
#135176	constant GLFW_ACCUM_GREEN_BITS
#135177	constant GLFW_ACCUM_BLUE_BITS
#135178	constant GLFW_ACCUM_ALPHA_BITS
#135179	constant GLFW_AUX_BUFFERS
#135180	constant GLFW_STEREO
#135181	constant GLFW_SAMPLES
#135182	constant GLFW_SRGB_CAPABLE
#135183	constant GLFW_REFRESH_RATE
#135184	constant GLFW_DOUBLEBUFFER
#139265	constant GLFW_CLIENT_API
#139266	constant GLFW_CONTEXT_VERSION_MAJOR
#139267	constant GLFW_CONTEXT_VERSION_MINOR
#139268	constant GLFW_CONTEXT_REVISION
#139269	constant GLFW_CONTEXT_ROBUSTNESS
#139270	constant GLFW_OPENGL_FORWARD_COMPAT
#139271	constant GLFW_OPENGL_DEBUG_CONTEXT
#139272	constant GLFW_OPENGL_PROFILE
#139273	constant GLFW_CONTEXT_RELEASE_BEHAVIOR
#139274	constant GLFW_CONTEXT_NO_ERROR
#139275	constant GLFW_CONTEXT_CREATION_API
#139276	constant GLFW_SCALE_TO_MONITOR
#143361	constant GLFW_COCOA_RETINA_FRAMEBUFFER
#143362	constant GLFW_COCOA_FRAME_NAME
#143363	constant GLFW_COCOA_GRAPHICS_SWITCHING
#147457	constant GLFW_X11_CLASS_NAME
#147458	constant GLFW_X11_INSTANCE_NAME
#0	constant GLFW_NO_API
#196609	constant GLFW_OPENGL_API
#196610	constant GLFW_OPENGL_ES_API
#0	constant GLFW_NO_ROBUSTNESS
#200705	constant GLFW_NO_RESET_NOTIFICATION
#200706	constant GLFW_LOSE_CONTEXT_ON_RESET
#0	constant GLFW_OPENGL_ANY_PROFILE
#204801	constant GLFW_OPENGL_CORE_PROFILE
#204802	constant GLFW_OPENGL_COMPAT_PROFILE
#208897	constant GLFW_CURSOR
#208898	constant GLFW_STICKY_KEYS
#208899	constant GLFW_STICKY_MOUSE_BUTTONS
#208900	constant GLFW_LOCK_KEY_MODS
#212993	constant GLFW_CURSOR_NORMAL
#212994	constant GLFW_CURSOR_HIDDEN
#212995	constant GLFW_CURSOR_DISABLED
#0	constant GLFW_ANY_RELEASE_BEHAVIOR
#217089	constant GLFW_RELEASE_BEHAVIOR_FLUSH
#217090	constant GLFW_RELEASE_BEHAVIOR_NONE
#221185	constant GLFW_NATIVE_CONTEXT_API
#221186	constant GLFW_EGL_CONTEXT_API
#221187	constant GLFW_OSMESA_CONTEXT_API
#221185	constant GLFW_ARROW_CURSOR
#221186	constant GLFW_IBEAM_CURSOR
#221187	constant GLFW_CROSSHAIR_CURSOR
#221188	constant GLFW_HAND_CURSOR
#221189	constant GLFW_HRESIZE_CURSOR
#221190	constant GLFW_VRESIZE_CURSOR
#262145	constant GLFW_CONNECTED
#262146	constant GLFW_DISCONNECTED
#327681	constant GLFW_JOYSTICK_HAT_BUTTONS
#331777	constant GLFW_COCOA_CHDIR_RESOURCES
#331778	constant GLFW_COCOA_MENUBAR
#-1	constant GLFW_DONT_CARE

\ -------===< structs >===--------
\ GLFWvidmode
begin-structure GLFWvidmode
	drop 16 4 +field GLFWvidmode-blueBits
	drop 20 4 +field GLFWvidmode-refreshRate
	drop 12 4 +field GLFWvidmode-greenBits
	drop 4 4 +field GLFWvidmode-height
	drop 0 4 +field GLFWvidmode-width
	drop 8 4 +field GLFWvidmode-redBits
drop 24 end-structure
\ GLFWgammaramp
begin-structure GLFWgammaramp
	drop 16 8 +field GLFWgammaramp-blue
	drop 8 8 +field GLFWgammaramp-green
	drop 0 8 +field GLFWgammaramp-red
	drop 24 4 +field GLFWgammaramp-size
drop 32 end-structure
\ GLFWimage
begin-structure GLFWimage
	drop 4 4 +field GLFWimage-height
	drop 0 4 +field GLFWimage-width
	drop 8 8 +field GLFWimage-pixels
drop 16 end-structure
\ GLFWgamepadstate
begin-structure GLFWgamepadstate
	drop 0 15 +field GLFWgamepadstate-buttons
	drop 16 24 +field GLFWgamepadstate-axes
drop 40 end-structure

\ ------===< callbacks >===-------
c-callback GLFWglproc:  -- void	( <noname> -- )
c-callback GLFWvkproc:  -- void	( <noname> -- )
c-callback GLFWerrorfun: n s -- void	( <noname> <noname> -- )
c-callback GLFWwindowposfun: a n n -- void	( <noname> <noname> <noname> -- )
c-callback GLFWwindowsizefun: a n n -- void	( <noname> <noname> <noname> -- )
c-callback GLFWwindowclosefun: a -- void	( <noname> -- )
c-callback GLFWwindowrefreshfun: a -- void	( <noname> -- )
c-callback GLFWwindowfocusfun: a n -- void	( <noname> <noname> -- )
c-callback GLFWwindowiconifyfun: a n -- void	( <noname> <noname> -- )
c-callback GLFWwindowmaximizefun: a n -- void	( <noname> <noname> -- )
c-callback GLFWframebuffersizefun: a n n -- void	( <noname> <noname> <noname> -- )
c-callback GLFWwindowcontentscalefun: a r r -- void	( <noname> <noname> <noname> -- )
c-callback GLFWmousebuttonfun: a n n n -- void	( <noname> <noname> <noname> <noname> -- )
c-callback GLFWcursorposfun: a r r -- void	( <noname> <noname> <noname> -- )
c-callback GLFWcursorenterfun: a n -- void	( <noname> <noname> -- )
c-callback GLFWscrollfun: a r r -- void	( <noname> <noname> <noname> -- )
c-callback GLFWkeyfun: a n n n n -- void	( <noname> <noname> <noname> <noname> <noname> -- )
c-callback GLFWcharfun: a u -- void	( <noname> <noname> -- )
c-callback GLFWcharmodsfun: a u n -- void	( <noname> <noname> <noname> -- )
c-callback GLFWdropfun: a n a -- void	( <noname> <noname> <noname> -- )
c-callback GLFWmonitorfun: a n -- void	( <noname> <noname> -- )
c-callback GLFWjoystickfun: n n -- void	( <noname> <noname> -- )

\ ------===< functions >===-------
c-function glfwInit glfwInit  -- n	( -- )
c-function glfwTerminate glfwTerminate  -- void	( -- )
c-function glfwInitHint glfwInitHint n n -- void	( hint value -- )
c-function glfwGetVersion glfwGetVersion a a a -- void	( major minor rev -- )
c-function glfwGetVersionString glfwGetVersionString  -- s	( -- )
c-function glfwGetError glfwGetError a -- n	( description -- )
c-function glfwSetErrorCallback glfwSetErrorCallback a -- a	( cbfun -- )
c-function glfwGetMonitors glfwGetMonitors a -- a	( count -- )
c-function glfwGetPrimaryMonitor glfwGetPrimaryMonitor  -- a	( -- )
c-function glfwGetMonitorPos glfwGetMonitorPos a a a -- void	( monitor xpos ypos -- )
c-function glfwGetMonitorPhysicalSize glfwGetMonitorPhysicalSize a a a -- void	( monitor widthMM heightMM -- )
c-function glfwGetMonitorContentScale glfwGetMonitorContentScale a a a -- void	( monitor xscale yscale -- )
c-function glfwGetMonitorName glfwGetMonitorName a -- s	( monitor -- )
c-function glfwSetMonitorUserPointer glfwSetMonitorUserPointer a a -- void	( monitor pointer -- )
c-function glfwGetMonitorUserPointer glfwGetMonitorUserPointer a -- a	( monitor -- )
c-function glfwSetMonitorCallback glfwSetMonitorCallback a -- a	( cbfun -- )
c-function glfwGetVideoModes glfwGetVideoModes a a -- a	( monitor count -- )
c-function glfwGetVideoMode glfwGetVideoMode a -- a	( monitor -- )
c-function glfwSetGamma glfwSetGamma a r -- void	( monitor gamma -- )
c-function glfwGetGammaRamp glfwGetGammaRamp a -- a	( monitor -- )
c-function glfwSetGammaRamp glfwSetGammaRamp a a -- void	( monitor ramp -- )
c-function glfwDefaultWindowHints glfwDefaultWindowHints  -- void	( -- )
c-function glfwWindowHint glfwWindowHint n n -- void	( hint value -- )
c-function glfwWindowHintString glfwWindowHintString n s -- void	( hint value -- )
c-function glfwCreateWindow glfwCreateWindow n n s a a -- a	( width height title monitor share -- )
c-function glfwDestroyWindow glfwDestroyWindow a -- void	( window -- )
c-function glfwWindowShouldClose glfwWindowShouldClose a -- n	( window -- )
c-function glfwSetWindowShouldClose glfwSetWindowShouldClose a n -- void	( window value -- )
c-function glfwSetWindowTitle glfwSetWindowTitle a s -- void	( window title -- )
c-function glfwSetWindowIcon glfwSetWindowIcon a n a -- void	( window count images -- )
c-function glfwGetWindowPos glfwGetWindowPos a a a -- void	( window xpos ypos -- )
c-function glfwSetWindowPos glfwSetWindowPos a n n -- void	( window xpos ypos -- )
c-function glfwGetWindowSize glfwGetWindowSize a a a -- void	( window width height -- )
c-function glfwSetWindowSizeLimits glfwSetWindowSizeLimits a n n n n -- void	( window minwidth minheight maxwidth maxheight -- )
c-function glfwSetWindowAspectRatio glfwSetWindowAspectRatio a n n -- void	( window numer denom -- )
c-function glfwSetWindowSize glfwSetWindowSize a n n -- void	( window width height -- )
c-function glfwGetFramebufferSize glfwGetFramebufferSize a a a -- void	( window width height -- )
c-function glfwGetWindowFrameSize glfwGetWindowFrameSize a a a a a -- void	( window left top right bottom -- )
c-function glfwGetWindowContentScale glfwGetWindowContentScale a a a -- void	( window xscale yscale -- )
c-function glfwGetWindowOpacity glfwGetWindowOpacity a -- r	( window -- )
c-function glfwSetWindowOpacity glfwSetWindowOpacity a r -- void	( window opacity -- )
c-function glfwIconifyWindow glfwIconifyWindow a -- void	( window -- )
c-function glfwRestoreWindow glfwRestoreWindow a -- void	( window -- )
c-function glfwMaximizeWindow glfwMaximizeWindow a -- void	( window -- )
c-function glfwShowWindow glfwShowWindow a -- void	( window -- )
c-function glfwHideWindow glfwHideWindow a -- void	( window -- )
c-function glfwFocusWindow glfwFocusWindow a -- void	( window -- )
c-function glfwRequestWindowAttention glfwRequestWindowAttention a -- void	( window -- )
c-function glfwGetWindowMonitor glfwGetWindowMonitor a -- a	( window -- )
c-function glfwSetWindowMonitor glfwSetWindowMonitor a a n n n n n -- void	( window monitor xpos ypos width height refreshRate -- )
c-function glfwGetWindowAttrib glfwGetWindowAttrib a n -- n	( window attrib -- )
c-function glfwSetWindowAttrib glfwSetWindowAttrib a n n -- void	( window attrib value -- )
c-function glfwSetWindowUserPointer glfwSetWindowUserPointer a a -- void	( window pointer -- )
c-function glfwGetWindowUserPointer glfwGetWindowUserPointer a -- a	( window -- )
c-function glfwSetWindowPosCallback glfwSetWindowPosCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowSizeCallback glfwSetWindowSizeCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowCloseCallback glfwSetWindowCloseCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowRefreshCallback glfwSetWindowRefreshCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowFocusCallback glfwSetWindowFocusCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowIconifyCallback glfwSetWindowIconifyCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowMaximizeCallback glfwSetWindowMaximizeCallback a a -- a	( window cbfun -- )
c-function glfwSetFramebufferSizeCallback glfwSetFramebufferSizeCallback a a -- a	( window cbfun -- )
c-function glfwSetWindowContentScaleCallback glfwSetWindowContentScaleCallback a a -- a	( window cbfun -- )
c-function glfwPollEvents glfwPollEvents  -- void	( -- )
c-function glfwWaitEvents glfwWaitEvents  -- void	( -- )
c-function glfwWaitEventsTimeout glfwWaitEventsTimeout r -- void	( timeout -- )
c-function glfwPostEmptyEvent glfwPostEmptyEvent  -- void	( -- )
c-function glfwGetInputMode glfwGetInputMode a n -- n	( window mode -- )
c-function glfwSetInputMode glfwSetInputMode a n n -- void	( window mode value -- )
c-function glfwGetKeyName glfwGetKeyName n n -- s	( key scancode -- )
c-function glfwGetKeyScancode glfwGetKeyScancode n -- n	( key -- )
c-function glfwGetKey glfwGetKey a n -- n	( window key -- )
c-function glfwGetMouseButton glfwGetMouseButton a n -- n	( window button -- )
c-function glfwGetCursorPos glfwGetCursorPos a a a -- void	( window xpos ypos -- )
c-function glfwSetCursorPos glfwSetCursorPos a r r -- void	( window xpos ypos -- )
c-function glfwCreateCursor glfwCreateCursor a n n -- a	( image xhot yhot -- )
c-function glfwCreateStandardCursor glfwCreateStandardCursor n -- a	( shape -- )
c-function glfwDestroyCursor glfwDestroyCursor a -- void	( cursor -- )
c-function glfwSetCursor glfwSetCursor a a -- void	( window cursor -- )
c-function glfwSetKeyCallback glfwSetKeyCallback a a -- a	( window cbfun -- )
c-function glfwSetCharCallback glfwSetCharCallback a a -- a	( window cbfun -- )
c-function glfwSetCharModsCallback glfwSetCharModsCallback a a -- a	( window cbfun -- )
c-function glfwSetMouseButtonCallback glfwSetMouseButtonCallback a a -- a	( window cbfun -- )
c-function glfwSetCursorPosCallback glfwSetCursorPosCallback a a -- a	( window cbfun -- )
c-function glfwSetCursorEnterCallback glfwSetCursorEnterCallback a a -- a	( window cbfun -- )
c-function glfwSetScrollCallback glfwSetScrollCallback a a -- a	( window cbfun -- )
c-function glfwSetDropCallback glfwSetDropCallback a a -- a	( window cbfun -- )
c-function glfwJoystickPresent glfwJoystickPresent n -- n	( jid -- )
c-function glfwGetJoystickAxes glfwGetJoystickAxes n a -- a	( jid count -- )
c-function glfwGetJoystickButtons glfwGetJoystickButtons n a -- a	( jid count -- )
c-function glfwGetJoystickHats glfwGetJoystickHats n a -- a	( jid count -- )
c-function glfwGetJoystickName glfwGetJoystickName n -- s	( jid -- )
c-function glfwGetJoystickGUID glfwGetJoystickGUID n -- s	( jid -- )
c-function glfwSetJoystickUserPointer glfwSetJoystickUserPointer n a -- void	( jid pointer -- )
c-function glfwGetJoystickUserPointer glfwGetJoystickUserPointer n -- a	( jid -- )
c-function glfwJoystickIsGamepad glfwJoystickIsGamepad n -- n	( jid -- )
c-function glfwSetJoystickCallback glfwSetJoystickCallback a -- a	( cbfun -- )
c-function glfwUpdateGamepadMappings glfwUpdateGamepadMappings s -- n	( string -- )
c-function glfwGetGamepadName glfwGetGamepadName n -- s	( jid -- )
c-function glfwGetGamepadState glfwGetGamepadState n a -- n	( jid state -- )
c-function glfwSetClipboardString glfwSetClipboardString a s -- void	( window string -- )
c-function glfwGetClipboardString glfwGetClipboardString a -- s	( window -- )
c-function glfwGetTime glfwGetTime  -- r	( -- )
c-function glfwSetTime glfwSetTime r -- void	( time -- )
c-function glfwGetTimerValue glfwGetTimerValue  -- n	( -- )
c-function glfwGetTimerFrequency glfwGetTimerFrequency  -- n	( -- )
c-function glfwMakeContextCurrent glfwMakeContextCurrent a -- void	( window -- )
c-function glfwGetCurrentContext glfwGetCurrentContext  -- a	( -- )
c-function glfwSwapBuffers glfwSwapBuffers a -- void	( window -- )
c-function glfwSwapInterval glfwSwapInterval n -- void	( interval -- )
c-function glfwExtensionSupported glfwExtensionSupported s -- n	( extension -- )
c-function glfwGetProcAddress glfwGetProcAddress s -- a	( procname -- )
c-function glfwVulkanSupported glfwVulkanSupported  -- n	( -- )
c-function glfwGetRequiredInstanceExtensions glfwGetRequiredInstanceExtensions a -- a	( count -- )

end-c-library
