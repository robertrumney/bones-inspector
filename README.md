# Bones-Inspector

Expose and modify the bones array of a `SkinnedMeshRenderer` directly in the Unity Inspector with this custom editor script.

## Features

- **Bone Visibility**: Instantly view all bones linked to the `SkinnedMeshRenderer`.
- **Modify Bones**: Directly reassign and modify bone assignments within the Unity Inspector.
- **Copy & Paste Bones**: Easily copy the bone setup from one `SkinnedMeshRenderer` and paste it onto another.
- **Reorder Bones**: Reorder the bone hierarchy directly within the Unity Inspector with a draggable list.

## Usage

1. **Bone Inspection**:
   - Select any GameObject with a `SkinnedMeshRenderer` component.
   - The inspector will display the list of associated bones at the bottom.
   
2. **Reordering Bones**:
   - Use the drag handles on the left side of the bone list to rearrange the order of bones.

3. **Copy & Paste**:
   - Click the "Copy Bones" button to copy the current list of bones.
   - Select another `SkinnedMeshRenderer` and click the "Paste Bones" button to apply the copied bones to it.

## Notes

While the script allows for viewing, modification, and reordering of bone assignments, please remember that any changes will be effective only if the bones are correctly set up with the mesh in terms of weights and bindings. Ensure you are familiar with your mesh's rigging before making modifications.
