# xamarin-eg-experiments
Hello-world-like experiments to see if we can get EG, Xamarin, and the other things we need working together. This borrows data structures and test ideas from Microsoft's [ElectionGuard library](https://github.com/microsoft/electionguard-cpp/) and the now-deprecated Xamarin app there. 

All it does so far is generate a yes vote, a no vote, and an encrypted vote (which is always 1). Note that, in order to allow for homomorphic addition, a 'yes' vote is actually a 1 in the 'yes' selection and a 0 in the 'no' selection, and conversely for a 'no' vote.

Note that the ElectionGuard dlls aren't automatically in the right place - you'll have to save it appropriately and tell your IDE where to find it.
