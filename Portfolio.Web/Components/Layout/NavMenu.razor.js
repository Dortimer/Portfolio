
// export function registerClickOutside(element, dotNetHelper) {
//     function handleClick(event) {
//         if (!element.contains(event.target)) {
//             dotNetHelper.invokeMethodAsync("CloseMenu");
//         }
//     }

//     document.addEventListener("click", handleClick);

//     return {
//         dispose: () => {
//             document.removeEventListener("click", handleClick);
//         }
//     };
// }